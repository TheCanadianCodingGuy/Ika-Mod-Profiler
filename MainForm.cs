using Ionic.Zip;
using Newtonsoft.Json;
using playtarky.Models;
using playtarky.Resources.Forms.MainForm;
using playtarky.Utils;
using System.Diagnostics;

namespace playtarky
{
    public partial class MainForm : Form
    {
        //step 1 is actually profile handling, export/import for server/client and all them ip/port configs.
        //step 2 is to actually drag drop mods, see diffs from profile to game live
        //step 3 is to modify their config
        //step 4 is to actually be able to have a mod database from spt, with link to them and be able to download and install from the app.
        //TODO: err and not load if install is not found
        //TODO: Export client config without server stuff, fika required.
        //TODO: Normalize gamedir
        //TODO: Tab Indexes
        //TODO: Profile loading
        //TODO: BepInEx\config\com.fika.core.cfg force ip.
        //TODO: BepInEx\config\com.fika.core.cfg first line for version, unknown if file does not exist. (Or read metadata / version on dll)
        //TODO: Aki_Data\Server\configs.core.json display spt version
        //TODO: user\mods\fika-server\package.json display fika server version
        //TODO: Help with disclaimer, links to fika and spt mods.
        //TODO: Message on load if profile not found, unselect profile and run app profileless.
        //TODO: PAD (exists/conditions) EVERY FILE HANDLING
        //TODO: Divide methods into classes.
        //TODO: Implement Dirty state
        //TODO: NOTHING CAN BE DONE WITHOUT AN ACTIVE PROFILE LOADED
        //TODO: No active profile = nothing enabled.

        public AppConfiguration? _app_config = null;
        public ProfileConfiguration? _active_Profile = null;


#if DEBUG
        public const string GAME_DIR = @"C:\SPT\";
#else
        public const string GAME_DIR = @".\";
#endif

        public const string GAME_PLUGINS_DIR_PARTIAL = @"BepInEx\plugins";
        public const string GAME_PLUGINS_DIR = $"{GAME_DIR}{GAME_PLUGINS_DIR_PARTIAL}";

        public const string GAME_USERMOD_DIR_PARTIAL = @"user\mods";
        public const string GAME_USERMOD_DIR = $"{GAME_DIR}{GAME_USERMOD_DIR_PARTIAL}";

        public const string GAME_USERPROFILES_DIR_PARTIAL = @"user\profiles";
        public const string GAME_USERPROFILES_DIR = $"{GAME_DIR}{GAME_USERPROFILES_DIR_PARTIAL}";

        public const string GAME_SERVERINFO_DIR_PARTIAL = @"Aki_Data\Server\configs";
        public const string GAME_SERVERINFO_DIR = $"{GAME_DIR}{GAME_SERVERINFO_DIR_PARTIAL}";
        public const string GAME_SERVERINFO_FILE = "http.json";
        public const string GAME_SERVERINFO_FILEPATH = @$"{GAME_DIR}{GAME_SERVERINFO_DIR_PARTIAL}\{GAME_SERVERINFO_FILE}";

        public const string GAME_LAUNCHERINFO_DIR_PARTIAL = @"user\launcher";
        public const string GAME_LAUNCHERINFO_DIR = $"{GAME_DIR}{GAME_LAUNCHERINFO_DIR_PARTIAL}";
        public const string GAME_LAUNCHERINFO_FILE = "config.json";
        public const string GAME_LAUNCHERINFO_FILEPATH = @$"{GAME_DIR}{GAME_LAUNCHERINFO_DIR_PARTIAL}\{GAME_LAUNCHERINFO_FILE}";

        public const string AKI_LAUNCHER_FILE = "Aki.Launcher.exe";
        public const string TARKOV_FILE = "EscapeFromTarkov.exe";

        //APP DIRS
        public const string APP_PROFILES_DIR_PARTIAL = "ikaprofiler";
        public const string APP_PROFILES_DIR = $"{GAME_DIR}{APP_PROFILES_DIR_PARTIAL}";

        public const string APP_CONFIG_FILENAME = "ikaprofiler.config.json";
        public const string APP_CONFIG_FILE = @$"{APP_PROFILES_DIR}\{APP_CONFIG_FILENAME}";

        public const string PROFILE_CONFIG_FILENAME = "ikaprofiler.profile.json";
        public const string CRASH_DUMP_PATH = @$"{GAME_DIR}ikaprofiler.crash.log.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                await InitializeProgram();
                InitializeTabBep();
                InitializeTabUser();
                InitializeTabServer();

                InitializeTabLauncher();
                InitializeTabProfiles();
            }
            catch (Exception ex)
            {
                CreateErrorDump(ex, MainFormResource.Error);
                Application.Exit();
            }
        }

        #region Configuration
        /// <summary>
        /// Saves json configuration to filesystem
        /// </summary>
        /// <param name="isActive">Pass a config to save (Optional)</param>
        private void SaveConfiguration(AppConfiguration? ac = null)
        {
            if (ac != null) _app_config = ac;
            // Serialize the object to JSON string
            string jsonString = JsonConvert.SerializeObject(_app_config);

            // Write the JSON string to the file
            File.WriteAllText(APP_CONFIG_FILE, jsonString);
        }

        private void LoadConfiguration()
        {
            string jsonText = File.ReadAllText(APP_CONFIG_FILE);
            _app_config = JsonConvert.DeserializeObject<AppConfiguration>(jsonText);
        }
        #endregion

        /// <summary>
        /// Cleanup crash files, initialize configuration file and handles first run.
        /// </summary>
        private async Task InitializeProgram()
        {
            //Add empty profile to the open menu just to allow the arrow to be visible.
            menu_openprofile_lbl.DropDownItems.Add(new ToolStripMenuItem(MenuStripResource.Empty) { Enabled = false });

            //Detect Tarkov
            if (!File.Exists(Path.Combine(GAME_DIR, TARKOV_FILE)))
            {
                MessageBox.Show(MainFormResource.TarkovNotFound, MainFormResource.StatusNotFound);
                Application.Exit();
            }

            //Detect SPT
            if (!File.Exists(Path.Combine(GAME_DIR, AKI_LAUNCHER_FILE)))
            {
                MessageBox.Show(MainFormResource.SPTNotFound, MainFormResource.StatusNotFound);
                Application.Exit();
            }


            //First run
            if (!Directory.Exists(APP_PROFILES_DIR))
            {
                Directory.CreateDirectory(APP_PROFILES_DIR);
                File.WriteAllText(APP_CONFIG_FILE, JsonConvert.SerializeObject(new AppConfiguration()));
            }

            //purge any tmp bck files if app crashed.
            foreach (string file in Directory.GetFiles(APP_PROFILES_DIR, "*.tmp")) File.Delete(file);
            foreach (string file in Directory.GetFiles(APP_PROFILES_DIR, "*.bck")) File.Delete(file);

            //If no profile, ask user to create one.
            var profiles = GetProfiles();
            if (profiles == null || profiles.Count == 0)
            {
                DialogResult result = MessageBox.Show(MainFormResource.NoProfileFoundCreateQ, MainFormResource.NoProfileFound);

                if (result == DialogResult.Yes)
                {
                    CreateNewProfileModal();
                }
            }

            if (_app_config == null)
            {
                LoadConfiguration();
            }

            if (_active_Profile == null)
            {
                LoadActiveProfile();
            }
        }

        #region Tab BepExIn
        /// <summary>
        /// Load tab data
        /// </summary>
        private void InitializeTabBep()
        {
            //load gamefiles
            bep_tab_gamefiles_lbox.Items.Clear();
            bep_tab_gamefiles_lbox.Items.AddRange([.. Helpers.GetFileSystemList(GAME_PLUGINS_DIR)]);

            //TODO: load profilefiles

            //TODO: colorcode
        }

        /// <summary>
        /// Show the "open file explorer" button on mouse over
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void bep_tab_gamefiles_lbox_MouseEnter(object sender, EventArgs e)
        {
            bep_tab_opengamefile_btn.Show();
        }

        /// <summary>
        /// Show the "open file explorer" button on mouse over
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void bep_tab_profilefiles_lbox_MouseEnter(object sender, EventArgs e)
        {
            bep_tab_openprofilefile_btn.Show();
        }

        /// <summary>
        /// Hide the "open file explorer" button
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void bepInExPluginsTab_MouseEnter(object sender, EventArgs e)
        {
            bep_tab_opengamefile_btn.Hide();
            bep_tab_openprofilefile_btn.Hide();
        }
        #endregion

        #region Tab User\Mods
        /// <summary>
        /// Load tab data
        /// </summary>
        private void InitializeTabUser()
        {
            //load gamefiles
            user_tab_gamefiles_lbox.Items.Clear();
            user_tab_gamefiles_lbox.Items.AddRange([.. Helpers.GetFileSystemList(GAME_USERMOD_DIR)]);

            //TODO: load profilefiles

            //TODO: colorcode
        }

        /// <summary>
        /// Reloads the data for the tab
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void refresh_mod_btn_Click(object sender, EventArgs e)
        {
            InitializeTabUser();
        }

        /// <summary>
        /// Show the "open file explorer" button on mouse over
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void open_game_user_btn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", GAME_USERMOD_DIR);
        }
        #endregion

        #region Tab Server Info
        /// <summary>
        /// Load tab data
        /// </summary>
        private void InitializeTabServer()
        {
            //TODO: Check if we can use fewer fields.
            //TODO: Make sure that non-seen fields are not overriden on save.
            //load gamefiles
            var file = Helpers.GetJsonFile<ServerHttpConfigurationFile>(GAME_SERVERINFO_FILEPATH);
            SI_ip_txt.Text = file.File.ip;
            SI_port_txt.Text = file.File.port.ToString();
            SI_beip_txt.Text = file.File.backendIp;
            SI_beport_txt.Text = file.File.backendPort.ToString();
            SI_wsdelay_txt.Text = file.File.webSocketPingDelayMs.ToString();
            SI_logreq_chk.Checked = file.File.logRequests;

            //TODO: load profilefiles

            //TODO: colorcode
        }

        /// <summary>
        /// Reloads the data for the tab
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void SI_reload_btn_Click(object sender, EventArgs e)
        {
            InitializeTabServer();
        }
        #endregion

        #region Tab Launcher Info
        private void InitializeTabLauncher()
        {
            //TODO: Check if we can use fewer fields.
            //TODO: Make sure that non-seen fields are not overriden on save.
            //load gamefiles
            var file = Helpers.GetJsonFile<LauncherConfigurationFile>(GAME_LAUNCHERINFO_FILEPATH);
            LI_useAutoLogin_chk.Checked = file.File.UseAutoLogin;
            LI_firstrun_chk.Checked = file.File.FirstRun;
            LI_username_txt.Text = file.File.Server.AutoLoginCreds.Username;
            LI_password_txt.Text = file.File.Server.AutoLoginCreds.Password;
            LI_defaultlocale_txt.Text = file.File.DefaultLocale;
            LI_servername_txt.Text = file.File.Server.Name;
            LI_filepath_txt.Text = file.File.GamePath;
            LI_serverurl_txt.Text = file.File.Server.Url;

            //TODO: load profilefiles

            //TODO: colorcode
        }

        /// <summary>
        /// Reloads the data for the tab
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void LI_reload_btn_Click(object sender, EventArgs e)
        {
            InitializeTabLauncher();
        }

        #endregion

        #region Tab Profiles
        /// <summary>
        /// Load tab data
        /// </summary>
        private void InitializeTabProfiles()
        {
            profile_tab_gamefiles_lbox.Items.Clear();
            var profiles = Helpers.GetFileSystemList(GAME_USERPROFILES_DIR, Helpers.FileType.Files, true);
            foreach (var profile in profiles)
            {
                //TODO: Make sure that they have a profileConfigFile in them, otherwise do not include in the list.
                var file = JsonConvert.DeserializeObject<UserProfile>(File.ReadAllText(profile));
                profile_tab_gamefiles_lbox.Items.Add(Path.Combine(file.info.id, file.info.username));
            }
        }

        /// <summary>
        /// Reloads the data for the tab
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void profile_tab_refresh_btn_Click(object sender, EventArgs e)
        {
            InitializeTabProfiles();
        }

        /// <summary>
        /// Show the "open file explorer" button on mouse over
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void profile_tab_open_game_btn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", GAME_USERPROFILES_DIR);
        }

        #endregion

        #region Menu Strip
        /// <summary>
        /// Loads profile from the strip menu Open
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        /// <param name="menuItemText">profile clicked</param>
        private void OpenProfileItem_Click(object sender, EventArgs e, string menuItemText)
        {
            //TODO: If clicked on same profile, do nothing
            //TODO: check if dirty, if so, tell them.
            LoadProfile(menuItemText);
            //TODO: Load profile

        }

        /// <summary>
        /// Loads profiles for menu strip dynamically
        /// </summary>
        /// <param name="sender">event sender control</param>
        /// <param name="e">event</param>
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeMenuProfiles();
        }

        private void saveProfileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewProfileModal();
        }

        /// <summary>
        /// Loads profiles for menu strip dynamically
        /// </summary>
        private void InitializeMenuProfiles()
        {
            var list = GetProfiles(true);

            menu_openprofile_lbl.DropDownItems.Clear();
            foreach (var profile in list)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(profile);
                //Attach their own event to load
                toolStripMenuItem.Click += (sender, e) => OpenProfileItem_Click(sender, e, profile);
                menu_openprofile_lbl.DropDownItems.Add(toolStripMenuItem);
            }

            //If no profiles, just make it an empty list
            if (list.Count == 0)
            {
                menu_openprofile_lbl.DropDownItems.Add(new ToolStripMenuItem(MenuStripResource.Empty) { Enabled = false });
            }
        }
        #endregion

        /// <summary>
        /// App acts different if a profile is loaded or not.
        /// </summary>
        /// <param name="isActive">If a profile is active, open app functionalities</param>
        private void Toggle_Field_For_Profile_Activity(bool isActive)
        {
            //MenuItems
            saveProfileToolStripMenuItem.Enabled = isActive; //Inactive if no profile loaded

            //Bep Tab
            tab_bep_profilefiles_lbl.Enabled = isActive;
            bep_tab_profilefiles_lbox.Enabled = isActive;
            bep_tab_openprofilefile_btn.Enabled = isActive;
            bep_tab_importselected_btn.Enabled = isActive;
            bep_tab_importall_btn.Enabled = isActive;
            bep_tab_exportselected_btn.Enabled = isActive;
            bep_tab_exportall_btn.Enabled = isActive;

            //user tab
            user_tab_export_btn.Enabled = isActive;
            user_tab_import_btn.Enabled = isActive;
            user_tab_open_profile_btn.Enabled = isActive;
            user_tab_profilefile_lbl.Enabled = isActive;
            user_tab_profilefiles_lbox.Enabled = isActive;

            //profile tab
            profile_tab_profilefile_lbl.Enabled = isActive;
            profile_tab_profilefiles_lbox.Enabled = isActive;
            profile_tab_open_profile_btn.Enabled = isActive;
            profile_tab_import_btn.Enabled = isActive;
            profile_tab_export_btn.Enabled = isActive;

            //ServerInfo (Disabled for Stage 1)
            SI_ip_txt.Enabled = false;
            SI_port_txt.Enabled = false;
            SI_beip_txt.Enabled = false;
            SI_beport_txt.Enabled = false;
            SI_wsdelay_txt.Enabled = false;
            SI_logreq_chk.Enabled = false;

            //LauncherInfo (Disabled for Stage 1)
            LI_useAutoLogin_chk.Enabled = false;
            LI_firstrun_chk.Enabled = false;
            LI_username_txt.Enabled = false;
            LI_servername_txt.Enabled = false;
            LI_password_txt.Enabled = false;
            LI_filepath_txt.Enabled = false;
            LI_serverurl_txt.Enabled = false;
            LI_defaultlocale_txt.Enabled = false;
        }

        //All the label focus click on actualy elements
        #region Focus Events
        //Server Info Tab
        private void SI_ip_lbl_Click(object sender, EventArgs e) { SI_ip_txt.Focus(); }
        private void SI_port_lbl_Click(object sender, EventArgs e) { SI_port_txt.Focus(); }
        private void SI_beip_lbl_Click(object sender, EventArgs e) { SI_beip_txt.Focus(); }
        private void SI_beport_lbl_Click(object sender, EventArgs e) { SI_beport_txt.Focus(); }
        private void SI_wsdelay_lbl_Click(object sender, EventArgs e) { SI_wsdelay_txt.Focus(); }
        private void SI_logreq_lbl_Click(object sender, EventArgs e) { SI_logreq_chk.Checked = !SI_logreq_chk.Checked; }

        //Launcher Info Tab
        private void LI_useAutoLogin_lbl_Click(object sender, EventArgs e) { LI_useAutoLogin_chk.Checked = !LI_useAutoLogin_chk.Checked; }
        private void LI_firstrun_lbl_Click(object sender, EventArgs e) { LI_firstrun_chk.Checked = !LI_firstrun_chk.Checked; }
        private void LI_username_lbl_Click(object sender, EventArgs e) { LI_username_txt.Focus(); }
        private void LI_defaultlocale_lbl_Click(object sender, EventArgs e) { LI_defaultlocale_txt.Focus(); }
        private void LI_servername_lbl_Click(object sender, EventArgs e) { LI_servername_txt.Focus(); }
        private void LI_password_lbl_Click(object sender, EventArgs e) { LI_password_txt.Focus(); }
        private void LI_filepath_lbl_Click(object sender, EventArgs e) { LI_filepath_txt.Focus(); }
        private void LI_serverurl_lbl_Click(object sender, EventArgs e) { LI_serverurl_txt.Focus(); }
        #endregion

        #region ProfileHandling
        /// <summary>
        /// Create the modal for a new profile creation
        /// </summary>
        public async Task CreateNewProfileModal()
        {
            CreateProfileForm newProfileForm = new CreateProfileForm();
            if (newProfileForm.ShowDialog() == DialogResult.OK)
            {
                var profileName = CreateProfileForm.ProfileName;
                var usesFika = CreateProfileForm.UsesFika;
                var isFikaHost = CreateProfileForm.IsFikaHost;
                var isOverwriteProfile = CreateProfileForm.IsOverwriteProfile;
                await SaveNewProfile(profileName, new ProfileConfiguration
                {
                    IsFikaHost = isFikaHost,
                    UseFika = usesFika
                }, isOverwriteProfile);

                DialogResult result = MessageBox.Show(string.Format(MainFormResource.ActivateProfileText, profileName), MainFormResource.ActivateProfileTitle, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SaveConfiguration(new AppConfiguration() { ActiveProfile = profileName });
                    LoadActiveProfile();
                }
            }
        }

        /// <summary>
        /// Create a brand new profile and save it.
        /// </summary>
        /// <param name="profileName">Profile to Create</param>
        /// <param name="config">Config to save with the profile</param>
        /// <param name="replaceProfile">replace the existing profile with a new one</param>
        public async Task SaveNewProfile(string profileName, ProfileConfiguration config, bool replaceProfile = false)
        {
            //TODO: Implement Replace Profile
            //TODO: Replace profile needs to backup existing, stage the new one and delete the backup if succeed, or restore if failed.
            try
            {
                //Disables the form while the creation process is enabled
                this.BeginInvoke((MethodInvoker)delegate
                {
                    this.Enabled = false;
                    this.Cursor = Cursors.WaitCursor;
                });


                var profileDir = @$"{APP_PROFILES_DIR}\{profileName}";

                //backup existing profile
                if (replaceProfile)
                {
                    File.Move($"{profileDir}.zip", $"{profileDir}.zip.bck");
                }

                //Create staging folder
                Directory.CreateDirectory(profileDir);

                //Initiates the progress
                progressBar.Value = 25;
                progressStatusText.Text = MainFormResource.CopyingFiles;

                //Copy game files
                CopyDirectory(GAME_PLUGINS_DIR, @$"{profileDir}\{GAME_PLUGINS_DIR_PARTIAL}");
                CopyDirectory(GAME_USERMOD_DIR, @$"{profileDir}\{GAME_USERMOD_DIR_PARTIAL}");
                CopyDirectory(GAME_USERPROFILES_DIR, @$"{profileDir}\{GAME_USERPROFILES_DIR_PARTIAL}");
                Directory.CreateDirectory(@$"{profileDir}\{GAME_SERVERINFO_DIR_PARTIAL}");
                File.Copy(GAME_SERVERINFO_FILEPATH, @$"{profileDir}\{GAME_SERVERINFO_DIR_PARTIAL}\{GAME_SERVERINFO_FILE}");
                Directory.CreateDirectory(@$"{profileDir}\{GAME_LAUNCHERINFO_DIR_PARTIAL}");
                File.Copy(GAME_LAUNCHERINFO_FILEPATH, @$"{profileDir}\{GAME_LAUNCHERINFO_DIR_PARTIAL}\{GAME_LAUNCHERINFO_FILE}");
                File.WriteAllText($@"{profileDir}\{PROFILE_CONFIG_FILENAME}", JsonConvert.SerializeObject(config));

                //Create profile zip
                progressStatusText.Text = MainFormResource.CreatingProfile;
                using ZipFile zip = new ZipFile();
                zip.AddDirectory(profileDir);
                zip.SaveProgress += (sender, e) =>
                {
                    // Check if the form's handle has been created
                    if (this.IsHandleCreated)
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            var p = (int)Math.Round(e.EntriesSaved / 100.0 * e.EntriesTotal);
                            progressBar.Value = p > 100 ? 100 : p;
                        });
                    }
                    else
                    {
                        var p = (int)Math.Round(e.EntriesSaved / 100.0 * e.EntriesTotal);
                        progressBar.Value = p > 100 ? 100 : p;
                    }
                };
                await Task.Run(() => zip.Save($"{profileDir}.zip"));

                //Delete staging folder
                Directory.Delete(profileDir, true);

                //Delete old existing profile
                if (replaceProfile)
                {
                    File.Delete($"{profileDir}.zip.bck");
                }

                //Update progress
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        progressBar.Value = 100;
                        progressStatusText.Text = string.Format(MainFormResource.ProfileCreated, $"{profileDir}.zip");
                    });
                }
                else
                {
                    progressBar.Value = 100;
                    progressStatusText.Text = string.Format(MainFormResource.ProfileCreated, profileDir);
                }
            }
            catch (Exception ex)
            {
                //Purge failed profile, zip and any tmp file left from process if any.
                var profileDir = @$"{APP_PROFILES_DIR}\{profileName}";
                if (Directory.Exists(profileDir))
                {
                    Directory.Delete(profileDir, true);
                }

                if (File.Exists($"{profileDir}.zip"))
                {
                    File.Delete($"{profileDir}.zip");
                }

                foreach (string file in Directory.GetFiles(APP_PROFILES_DIR, "*.tmp")) File.Delete(file);

                //restore existing profile
                if (replaceProfile)
                {
                    File.Move($"{profileDir}.zip.bck", $"{profileDir}.zip");
                }

                //Dump Error
                CreateErrorDump(ex, MainFormResource.ErrorCreatingProfile);
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Enabled = true;
                    this.Cursor = Cursors.Default;
                });
            }
        }

        /// <summary>
        /// Get a list of user profiles file names
        /// </summary>
        /// <param name="WithoutExtension">returns the list without ".zip"</param>
        /// <returns>list of profiles</returns>
        private List<string> GetProfiles(bool WithoutExtension = false)
        { 
            var profile_list = new List<string>();
            foreach (var profile in Directory.GetFiles(APP_PROFILES_DIR, "*.zip"))
            {
                var staging = profile;
                if (WithoutExtension) staging = Path.GetFileNameWithoutExtension(staging);
                profile_list.Add(staging);
            }
            return profile_list;
        }

        /// <summary>
        /// Load a profile to be active
        /// </summary>
        private void LoadActiveProfile()
        {
            //check if profile exists. 
            if (!string.IsNullOrWhiteSpace(_app_config.ActiveProfile))
            {
                LoadProfile(_app_config.ActiveProfile, true);
            }
        }

        public void LoadProfile(string profileName, bool isAutoActiveProfile = false)
        {
            var isprofileOk = false;
            var path = $"{Path.Combine(APP_PROFILES_DIR, profileName)}.zip";
            isprofileOk = File.Exists(path);
            if (isprofileOk)
            {
                //Check if contains profile file.
                using ZipFile zip = ZipFile.Read(path);
                isprofileOk = false;
                foreach (ZipEntry entry in zip)
                {
                    if (entry.FileName == PROFILE_CONFIG_FILENAME)
                    {
                        using MemoryStream stream = new();
                        entry.Extract(stream);
                        stream.Seek(0, SeekOrigin.Begin);

                        using StreamReader reader = new(stream);
                        string jsonContent = reader.ReadToEnd();
                        _active_Profile = JsonConvert.DeserializeObject<ProfileConfiguration>(jsonContent);
                        _app_config.ActiveProfile = profileName;
                        MF_profileloaded_txt.Text = profileName;
                        SaveConfiguration();
                        isprofileOk = true;
                        progressBar.Value = 100;
                        progressStatusText.Text = string.Format(MainFormResource.ProfileLoaded, profileName);
                    }
                }
            }
            else
            {
                var title = isAutoActiveProfile ? MainFormResource.ActiveProfileMissingTitle : MainFormResource.ProfileCorruptedTitle;
                var message = isAutoActiveProfile ? MainFormResource.ActiveProfileMissingMsg : MainFormResource.ProfileCorruptedMsg;
                MessageBox.Show(string.Format(message, profileName), title);
                progressBar.Value = 0;
                progressStatusText.Text = string.Format(MainFormResource.ProfileCorruptedProgressMsg, profileName);
            }

            Toggle_Field_For_Profile_Activity(isprofileOk);
        }
        #endregion

        /// <summary>
        /// Copy all directories and files
        /// </summary>
        /// <param name="sourceDir">Where from</param>
        /// <param name="targetDir">Where to</param>
        public void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDir, fileName);
                File.Copy(file, destFile, true);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string dirName = new DirectoryInfo(subDir).Name;
                string destDir = Path.Combine(targetDir, dirName);
                CopyDirectory(subDir, destDir);
            }
        }

        #region Error Dump
        /// <summary>
        /// Creates an error crash file with data for debug in the root folder.
        /// </summary>
        /// <param name="ex">Exception to log</param>
        /// <param name="title">Title of the error modal</param>
        private void CreateErrorDump(Exception ex, string title)
        {

            string osVersion = Environment.OSVersion.VersionString;
            Version appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            // Write the error details to the file
            using (StreamWriter writer = new StreamWriter(CRASH_DUMP_PATH))
            {
                writer.WriteLine("OS Version: " + osVersion);
                writer.WriteLine($"Application Version: {appVersion}");
                writer.WriteLine($"Current Time (UTC): {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}\n\n");
                writer.WriteLine($"Exception Message: {ex.Message}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}\n");
                Exception innerEx = ex.InnerException;
                while (innerEx != null)
                {
                    writer.WriteLine($"Inner Exception Message: {innerEx.Message}");
                    writer.WriteLine($"Inner Exception Stack Trace: {innerEx.StackTrace}\n");
                    innerEx = innerEx.InnerException;
                }
                writer.WriteLine($"Running Path: {Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}");
                writer.WriteLine($"{GAME_PLUGINS_DIR} found: {Directory.Exists(GAME_PLUGINS_DIR)}");
                writer.WriteLine($"{GAME_USERMOD_DIR} found: {Directory.Exists(GAME_USERMOD_DIR)}");
                writer.WriteLine($"{GAME_USERPROFILES_DIR} found: {Directory.Exists(GAME_USERPROFILES_DIR)}");
                writer.WriteLine($"{GAME_SERVERINFO_DIR} found: {Directory.Exists(GAME_SERVERINFO_DIR)}");
                writer.WriteLine($"{GAME_SERVERINFO_FILEPATH} found: {File.Exists(GAME_SERVERINFO_FILEPATH)}");
                writer.WriteLine($"{GAME_LAUNCHERINFO_DIR} found: {Directory.Exists(GAME_LAUNCHERINFO_DIR)}");
                writer.WriteLine($"{GAME_LAUNCHERINFO_FILEPATH} found: {File.Exists(GAME_LAUNCHERINFO_FILEPATH)}");
                writer.WriteLine($"{APP_PROFILES_DIR} found: {Directory.Exists(APP_PROFILES_DIR)}");
                writer.WriteLine($"{APP_CONFIG_FILE} found: {File.Exists(APP_CONFIG_FILE)}");
                writer.WriteLine($"\nListing: {GAME_PLUGINS_DIR}");
                foreach (string dir in GetDirectoryListing(GAME_PLUGINS_DIR)) writer.WriteLine(dir);
                writer.WriteLine($"\nListing: {GAME_USERMOD_DIR}");
                foreach (string dir in GetDirectoryListing(GAME_USERMOD_DIR)) writer.WriteLine(dir);
                writer.WriteLine($"\nListing: {GAME_USERPROFILES_DIR}");
                foreach (string dir in GetDirectoryListing(GAME_USERPROFILES_DIR)) writer.WriteLine(dir);
                writer.WriteLine($"\nListing: {GAME_SERVERINFO_DIR}");
                foreach (string dir in GetDirectoryListing(GAME_SERVERINFO_DIR)) writer.WriteLine(dir);
                writer.WriteLine($"\nListing: {GAME_LAUNCHERINFO_DIR}");
                foreach (string dir in GetDirectoryListing(GAME_LAUNCHERINFO_DIR)) writer.WriteLine(dir);
                writer.WriteLine($"\nListing: {APP_PROFILES_DIR}");
                foreach (string dir in GetDirectoryListing(APP_PROFILES_DIR)) writer.WriteLine(dir);
            }

            MessageBox.Show($"{MainFormResource.ErrorCAPS}\n{ex.Message}\n\n{MainFormResource.CrashReportCreated}\n{CRASH_DUMP_PATH}", title);

            //Make sure the form window is back enabled
            progressBar.Value = 0;
            progressStatusText.Text = MainFormResource.Error;
        }

        /// <summary>
        /// Used for Error Crash Report. Gets file and folder names in relevant places to help point to an issue.
        /// </summary>
        /// <param name="path">Path to look in</param>
        /// <returns>List of files and folders</returns>
        private List<string> GetDirectoryListing(string path)
        {
            var listing = Directory.GetDirectories(path).ToList();
            listing.AddRange(Directory.GetFiles(path).ToList());
            return listing;
        }
        #endregion
    }
}
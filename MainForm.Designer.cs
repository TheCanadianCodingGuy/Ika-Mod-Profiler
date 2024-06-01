using playtarky.Resources.Forms.MainForm;
using playtarky.Resources.Forms.MainForm.TabContent;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace playtarky
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            progressBar = new ToolStripProgressBar();
            progressStatusText = new ToolStripStatusLabel();
            spt_version_lbl = new ToolStripStatusLabel();
            mainMenuTabs = new TabControl();
            bepInExPluginsTab = new TabPage();
            bep_tab_info_btn = new Button();
            bep_tab_exportall_btn = new Button();
            bep_tab_importselected_btn = new Button();
            bep_tab_openprofilefile_btn = new Button();
            bep_tab_opengamefile_btn = new Button();
            bep_tab_exportselected_btn = new Button();
            bep_tab_importall_btn = new Button();
            bep_tab_refresh_btn = new Button();
            bep_tab_profilefile_lbl = new Label();
            bep_tab_gamefile_lbl = new Label();
            bep_tab_profilefiles_lbox = new ListBox();
            bep_tab_gamefiles_lbox = new ListBox();
            UserModsTab = new TabPage();
            user_tab_profilefile_lbl = new Label();
            user_tab_open_profile_btn = new Button();
            user_tab_import_btn = new Button();
            user_tab_profilefiles_lbox = new ListBox();
            user_tab_gamefile_lbl = new Label();
            user_tab_refresh_btn = new Button();
            user_tab_export_btn = new Button();
            user_tab_open_game_btn = new Button();
            user_tab_gamefiles_lbox = new ListBox();
            ServerInfoTab = new TabPage();
            SI_reload_btn = new Button();
            SI_logreq_chk = new CheckBox();
            SI_logreq_lbl = new Label();
            SI_wsdelay_txt = new TextBox();
            SI_wsdelay_lbl = new Label();
            SI_beport_txt = new TextBox();
            SI_beport_lbl = new Label();
            SI_beip_txt = new TextBox();
            SI_beip_lbl = new Label();
            SI_port_txt = new TextBox();
            SI_port_lbl = new Label();
            SI_ip_txt = new TextBox();
            SI_ip_lbl = new Label();
            LauncherInfoTab = new TabPage();
            LI_reload_btn = new Button();
            LI_defaultlocale_txt = new TextBox();
            LI_defaultlocale_lbl = new Label();
            LI_serverurl_txt = new TextBox();
            LI_filepath_txt = new TextBox();
            LI_servername_txt = new TextBox();
            LI_firstrun_chk = new CheckBox();
            LI_filepath_lbl = new Label();
            LI_serverurl_lbl = new Label();
            LI_servername_lbl = new Label();
            LI_firstrun_lbl = new Label();
            LI_useAutoLogin_chk = new CheckBox();
            LI_password_txt = new MaskedTextBox();
            LI_password_lbl = new Label();
            LI_username_txt = new TextBox();
            LI_username_lbl = new Label();
            LI_useAutoLogin_lbl = new Label();
            ProfilesTab = new TabPage();
            profile_tab_import_btn = new Button();
            profile_tab_open_profile_btn = new Button();
            profile_tab_refresh_btn = new Button();
            profile_tab_export_btn = new Button();
            profile_tab_open_game_btn = new Button();
            profile_tab_profilefile_lbl = new Label();
            profile_tab_gamefile_lbl = new Label();
            profile_tab_profilefiles_lbox = new ListBox();
            profile_tab_gamefiles_lbox = new ListBox();
            serverHttpConfigurationFileBindingSource = new BindingSource(components);
            label1 = new Label();
            ProfileLinkLabel = new Label();
            fika_client_status_lbl = new Label();
            fika_server_status_lbl = new Label();
            label4 = new Label();
            label2 = new Label();
            bep_tab_openprofilefile_btn_tt = new ToolTip(components);
            bep_tab_opengamefile_btn_tt = new ToolTip(components);
            bep_list_helper_2_tt = new ToolTip(components);
            bep_list_helper_1_tt = new ToolTip(components);
            bep_tab_refresh_btn_tt = new ToolTip(components);
            bep_tab_exportall_btn_tt = new ToolTip(components);
            bep_tab_importselected_btn_tt = new ToolTip(components);
            bep_tab_exportselected_btn_tt = new ToolTip(components);
            bep_tab_importall_btn_tt = new ToolTip(components);
            bep_tab_info_btn_tt = new ToolTip(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainMenuTabs.SuspendLayout();
            bepInExPluginsTab.SuspendLayout();
            UserModsTab.SuspendLayout();
            ServerInfoTab.SuspendLayout();
            LauncherInfoTab.SuspendLayout();
            ProfilesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serverHttpConfigurationFileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openProfileToolStripMenuItem, saveProfileToolStripMenuItem, saveProfileAsToolStripMenuItem, toolStripSeparator1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = MenuStripResource.File;
            fileToolStripMenuItem.Click += FileToolStripMenuItem_Click;
            // 
            // openProfileToolStripMenuItem
            // 
            openProfileToolStripMenuItem.Name = "openProfileToolStripMenuItem";
            openProfileToolStripMenuItem.Size = new Size(190, 22);
            openProfileToolStripMenuItem.Text = MenuStripResource.OpenProfile;
            // 
            // saveProfileToolStripMenuItem
            // 
            saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            saveProfileToolStripMenuItem.Size = new Size(190, 22);
            saveProfileToolStripMenuItem.Text = MenuStripResource.SaveCurrentProfile;
            // 
            // saveProfileAsToolStripMenuItem
            // 
            saveProfileAsToolStripMenuItem.Name = "saveProfileAsToolStripMenuItem";
            saveProfileAsToolStripMenuItem.Size = new Size(190, 22);
            saveProfileAsToolStripMenuItem.Text = MenuStripResource.SaveProfileAs;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { progressBar, progressStatusText, spt_version_lbl });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            progressBar.Margin = new Padding(5, 3, 1, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 16);
            // 
            // progressStatusText
            // 
            progressStatusText.Name = "progressStatusText";
            progressStatusText.Size = new Size(0, 17);
            // 
            // spt_version_lbl
            // 
            spt_version_lbl.DisplayStyle = ToolStripItemDisplayStyle.Text;
            spt_version_lbl.Name = "spt_version_lbl";
            spt_version_lbl.RightToLeft = RightToLeft.No;
            spt_version_lbl.Size = new Size(679, 17);
            spt_version_lbl.Spring = true;
            spt_version_lbl.Text = "spt_version_lbl";
            spt_version_lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mainMenuTabs
            // 
            mainMenuTabs.Controls.Add(bepInExPluginsTab);
            mainMenuTabs.Controls.Add(UserModsTab);
            mainMenuTabs.Controls.Add(ServerInfoTab);
            mainMenuTabs.Controls.Add(LauncherInfoTab);
            mainMenuTabs.Controls.Add(ProfilesTab);
            mainMenuTabs.Location = new Point(0, 75);
            mainMenuTabs.Name = "mainMenuTabs";
            mainMenuTabs.SelectedIndex = 0;
            mainMenuTabs.Size = new Size(800, 291);
            mainMenuTabs.TabIndex = 2;
            // 
            // bepInExPluginsTab
            // 
            bepInExPluginsTab.Controls.Add(bep_tab_info_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_exportall_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_importselected_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_openprofilefile_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_opengamefile_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_exportselected_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_importall_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_refresh_btn);
            bepInExPluginsTab.Controls.Add(bep_tab_profilefile_lbl);
            bepInExPluginsTab.Controls.Add(bep_tab_gamefile_lbl);
            bepInExPluginsTab.Controls.Add(bep_tab_profilefiles_lbox);
            bepInExPluginsTab.Controls.Add(bep_tab_gamefiles_lbox);
            bepInExPluginsTab.Location = new Point(4, 24);
            bepInExPluginsTab.Name = "bepInExPluginsTab";
            bepInExPluginsTab.Padding = new Padding(3);
            bepInExPluginsTab.Size = new Size(792, 263);
            bepInExPluginsTab.TabIndex = 0;
            bepInExPluginsTab.Text = TabContentResource.BepInExPluginsTabTitle;
            bepInExPluginsTab.UseVisualStyleBackColor = true;
            bepInExPluginsTab.MouseEnter += bepInExPluginsTab_MouseEnter;
            // 
            // bep_tab_info_btn
            // 
            bep_tab_info_btn.Cursor = Cursors.Help;
            bep_tab_info_btn.Image = (Image)resources.GetObject("bep_tab_info_btn.Image");
            bep_tab_info_btn.Location = new Point(759, 39);
            bep_tab_info_btn.Name = "bep_tab_info_btn";
            bep_tab_info_btn.Size = new Size(30, 30);
            bep_tab_info_btn.TabIndex = 14;
            bep_tab_info_btn_tt.SetToolTip(bep_tab_info_btn, TabContentResource.ListBoxHelper);
            bep_tab_info_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_exportall_btn
            // 
            bep_tab_exportall_btn.Image = (Image)resources.GetObject("bep_tab_exportall_btn.Image");
            bep_tab_exportall_btn.Location = new Point(381, 204);
            bep_tab_exportall_btn.Name = "bep_tab_exportall_btn";
            bep_tab_exportall_btn.Size = new Size(30, 30);
            bep_tab_exportall_btn.TabIndex = 13;
            bep_tab_exportall_btn_tt.SetToolTip(bep_tab_exportall_btn, TabContentResource.ExportAll);
            bep_tab_exportall_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_importselected_btn
            // 
            bep_tab_importselected_btn.Image = (Image)resources.GetObject("bep_tab_importselected_btn.Image");
            bep_tab_importselected_btn.Location = new Point(381, 86);
            bep_tab_importselected_btn.Name = "bep_tab_importselected_btn";
            bep_tab_importselected_btn.Size = new Size(30, 30);
            bep_tab_importselected_btn.TabIndex = 12;
            bep_tab_importselected_btn_tt.SetToolTip(bep_tab_importselected_btn, TabContentResource.ImportSelected);
            bep_tab_importselected_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_openprofilefile_btn
            // 
            bep_tab_openprofilefile_btn.Image = (Image)resources.GetObject("bep_tab_openprofilefile_btn.Image");
            bep_tab_openprofilefile_btn.Location = new Point(707, 218);
            bep_tab_openprofilefile_btn.Name = "bep_tab_openprofilefile_btn";
            bep_tab_openprofilefile_btn.Size = new Size(30, 30);
            bep_tab_openprofilefile_btn.TabIndex = 11;
            bep_tab_openprofilefile_btn_tt.SetToolTip(bep_tab_openprofilefile_btn, TabContentResource.OpenFileExplorer);
            bep_tab_openprofilefile_btn.UseVisualStyleBackColor = true;
            bep_tab_openprofilefile_btn.Visible = false;
            // 
            // bep_tab_opengamefile_btn
            // 
            bep_tab_opengamefile_btn.Image = (Image)resources.GetObject("bep_tab_opengamefile_btn.Image");
            bep_tab_opengamefile_btn.Location = new Point(317, 218);
            bep_tab_opengamefile_btn.Name = "bep_tab_opengamefile_btn";
            bep_tab_opengamefile_btn.Size = new Size(30, 30);
            bep_tab_opengamefile_btn.TabIndex = 10;
            bep_tab_opengamefile_btn_tt.SetToolTip(bep_tab_opengamefile_btn, TabContentResource.OpenFileExplorer);
            bep_tab_opengamefile_btn.UseVisualStyleBackColor = true;
            bep_tab_opengamefile_btn.Visible = false;
            // 
            // bep_tab_exportselected_btn
            // 
            bep_tab_exportselected_btn.Image = (Image)resources.GetObject("bep_tab_exportselected_btn.Image");
            bep_tab_exportselected_btn.Location = new Point(381, 168);
            bep_tab_exportselected_btn.Name = "bep_tab_exportselected_btn";
            bep_tab_exportselected_btn.Size = new Size(30, 30);
            bep_tab_exportselected_btn.TabIndex = 9;
            bep_tab_exportselected_btn_tt.SetToolTip(bep_tab_exportselected_btn, TabContentResource.ExportSelected);
            bep_tab_exportselected_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_importall_btn
            // 
            bep_tab_importall_btn.Image = (Image)resources.GetObject("bep_tab_importall_btn.Image");
            bep_tab_importall_btn.Location = new Point(381, 50);
            bep_tab_importall_btn.Name = "bep_tab_importall_btn";
            bep_tab_importall_btn.Size = new Size(30, 30);
            bep_tab_importall_btn.TabIndex = 8;
            bep_tab_importall_btn_tt.SetToolTip(bep_tab_importall_btn, TabContentResource.ImportAll);
            bep_tab_importall_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_refresh_btn
            // 
            bep_tab_refresh_btn.Image = (Image)resources.GetObject("bep_tab_refresh_btn.Image");
            bep_tab_refresh_btn.Location = new Point(759, 3);
            bep_tab_refresh_btn.Name = "bep_tab_refresh_btn";
            bep_tab_refresh_btn.Size = new Size(30, 30);
            bep_tab_refresh_btn.TabIndex = 7;
            bep_tab_refresh_btn_tt.SetToolTip(bep_tab_refresh_btn, TabContentResource.Refresh);
            bep_tab_refresh_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_profilefile_lbl
            // 
            bep_tab_profilefile_lbl.AutoSize = true;
            bep_tab_profilefile_lbl.Location = new Point(426, 18);
            bep_tab_profilefile_lbl.Name = "bep_tab_profilefile_lbl";
            bep_tab_profilefile_lbl.Size = new Size(67, 15);
            bep_tab_profilefile_lbl.TabIndex = 6;
            bep_tab_profilefile_lbl.Text = "Profile Files";
            // 
            // bep_tab_gamefile_lbl
            // 
            bep_tab_gamefile_lbl.AutoSize = true;
            bep_tab_gamefile_lbl.Location = new Point(36, 18);
            bep_tab_gamefile_lbl.Name = "bep_tab_gamefile_lbl";
            bep_tab_gamefile_lbl.Size = new Size(64, 15);
            bep_tab_gamefile_lbl.TabIndex = 5;
            bep_tab_gamefile_lbl.Text = "Game Files";
            // 
            // bep_tab_profilefiles_lbox
            // 
            bep_tab_profilefiles_lbox.FormattingEnabled = true;
            bep_tab_profilefiles_lbox.ItemHeight = 15;
            bep_tab_profilefiles_lbox.Location = new Point(426, 35);
            bep_tab_profilefiles_lbox.Name = "bep_tab_profilefiles_lbox";
            bep_tab_profilefiles_lbox.ScrollAlwaysVisible = true;
            bep_tab_profilefiles_lbox.SelectionMode = SelectionMode.None;
            bep_tab_profilefiles_lbox.Size = new Size(330, 214);
            bep_tab_profilefiles_lbox.TabIndex = 4;
            bep_tab_profilefiles_lbox.MouseEnter += bep_tab_profilefiles_lbox_MouseEnter;
            // 
            // bep_tab_gamefiles_lbox
            // 
            bep_tab_gamefiles_lbox.FormattingEnabled = true;
            bep_tab_gamefiles_lbox.ItemHeight = 15;
            bep_tab_gamefiles_lbox.Location = new Point(36, 35);
            bep_tab_gamefiles_lbox.Name = "bep_tab_gamefiles_lbox";
            bep_tab_gamefiles_lbox.ScrollAlwaysVisible = true;
            bep_tab_gamefiles_lbox.SelectionMode = SelectionMode.None;
            bep_tab_gamefiles_lbox.Size = new Size(330, 214);
            bep_tab_gamefiles_lbox.TabIndex = 0;
            bep_tab_gamefiles_lbox.MouseEnter += bep_tab_gamefiles_lbox_MouseEnter;
            // 
            // UserModsTab
            // 
            UserModsTab.Controls.Add(user_tab_profilefile_lbl);
            UserModsTab.Controls.Add(user_tab_open_profile_btn);
            UserModsTab.Controls.Add(user_tab_import_btn);
            UserModsTab.Controls.Add(user_tab_profilefiles_lbox);
            UserModsTab.Controls.Add(user_tab_gamefile_lbl);
            UserModsTab.Controls.Add(user_tab_refresh_btn);
            UserModsTab.Controls.Add(user_tab_export_btn);
            UserModsTab.Controls.Add(user_tab_open_game_btn);
            UserModsTab.Controls.Add(user_tab_gamefiles_lbox);
            UserModsTab.Location = new Point(4, 24);
            UserModsTab.Name = "UserModsTab";
            UserModsTab.Padding = new Padding(3);
            UserModsTab.Size = new Size(792, 263);
            UserModsTab.TabIndex = 1;
            UserModsTab.Text = TabContentResource.UserModTabTitle;
            UserModsTab.UseVisualStyleBackColor = true;
            // 
            // user_tab_profilefile_lbl
            // 
            user_tab_profilefile_lbl.AutoSize = true;
            user_tab_profilefile_lbl.Location = new Point(306, 18);
            user_tab_profilefile_lbl.Name = "user_tab_profilefile_lbl";
            user_tab_profilefile_lbl.Size = new Size(67, 15);
            user_tab_profilefile_lbl.TabIndex = 10;
            user_tab_profilefile_lbl.Text = "Profile Files";
            // 
            // user_tab_open_profile_btn
            // 
            user_tab_open_profile_btn.Location = new Point(612, 169);
            user_tab_open_profile_btn.Name = "user_tab_open_profile_btn";
            user_tab_open_profile_btn.Size = new Size(172, 23);
            user_tab_open_profile_btn.TabIndex = 9;
            user_tab_open_profile_btn.Text = TabContentResource.UserModTabTitle;
            user_tab_open_profile_btn.UseVisualStyleBackColor = true;
            // 
            // user_tab_import_btn
            // 
            user_tab_import_btn.Location = new Point(612, 198);
            user_tab_import_btn.Name = "user_tab_import_btn";
            user_tab_import_btn.Size = new Size(172, 23);
            user_tab_import_btn.TabIndex = 8;
            user_tab_import_btn.Text = "Import";
            user_tab_import_btn.UseVisualStyleBackColor = true;
            // 
            // user_tab_profilefiles_lbox
            // 
            user_tab_profilefiles_lbox.FormattingEnabled = true;
            user_tab_profilefiles_lbox.ItemHeight = 15;
            user_tab_profilefiles_lbox.Location = new Point(309, 36);
            user_tab_profilefiles_lbox.Name = "user_tab_profilefiles_lbox";
            user_tab_profilefiles_lbox.Size = new Size(297, 214);
            user_tab_profilefiles_lbox.TabIndex = 7;
            // 
            // user_tab_gamefile_lbl
            // 
            user_tab_gamefile_lbl.AutoSize = true;
            user_tab_gamefile_lbl.Location = new Point(3, 18);
            user_tab_gamefile_lbl.Name = "user_tab_gamefile_lbl";
            user_tab_gamefile_lbl.Size = new Size(64, 15);
            user_tab_gamefile_lbl.TabIndex = 6;
            user_tab_gamefile_lbl.Text = "Game Files";
            // 
            // user_tab_refresh_btn
            // 
            user_tab_refresh_btn.Location = new Point(612, 111);
            user_tab_refresh_btn.Name = "user_tab_refresh_btn";
            user_tab_refresh_btn.Size = new Size(172, 23);
            user_tab_refresh_btn.TabIndex = 4;
            user_tab_refresh_btn.Text = "Refresh";
            user_tab_refresh_btn.UseVisualStyleBackColor = true;
            user_tab_refresh_btn.Click += refresh_mod_btn_Click;
            // 
            // user_tab_export_btn
            // 
            user_tab_export_btn.Location = new Point(612, 227);
            user_tab_export_btn.Name = "user_tab_export_btn";
            user_tab_export_btn.Size = new Size(172, 23);
            user_tab_export_btn.TabIndex = 3;
            user_tab_export_btn.Text = "Export";
            user_tab_export_btn.UseVisualStyleBackColor = true;
            // 
            // user_tab_open_game_btn
            // 
            user_tab_open_game_btn.Location = new Point(612, 140);
            user_tab_open_game_btn.Name = "user_tab_open_game_btn";
            user_tab_open_game_btn.Size = new Size(172, 23);
            user_tab_open_game_btn.TabIndex = 2;
            user_tab_open_game_btn.Text = "open";
            user_tab_open_game_btn.UseVisualStyleBackColor = true;
            user_tab_open_game_btn.Click += open_game_user_btn_Click;
            // 
            // user_tab_gamefiles_lbox
            // 
            user_tab_gamefiles_lbox.FormattingEnabled = true;
            user_tab_gamefiles_lbox.ItemHeight = 15;
            user_tab_gamefiles_lbox.Location = new Point(6, 36);
            user_tab_gamefiles_lbox.Name = "user_tab_gamefiles_lbox";
            user_tab_gamefiles_lbox.Size = new Size(297, 214);
            user_tab_gamefiles_lbox.TabIndex = 0;
            // 
            // ServerInfoTab
            // 
            ServerInfoTab.Controls.Add(SI_reload_btn);
            ServerInfoTab.Controls.Add(SI_logreq_chk);
            ServerInfoTab.Controls.Add(SI_logreq_lbl);
            ServerInfoTab.Controls.Add(SI_wsdelay_txt);
            ServerInfoTab.Controls.Add(SI_wsdelay_lbl);
            ServerInfoTab.Controls.Add(SI_beport_txt);
            ServerInfoTab.Controls.Add(SI_beport_lbl);
            ServerInfoTab.Controls.Add(SI_beip_txt);
            ServerInfoTab.Controls.Add(SI_beip_lbl);
            ServerInfoTab.Controls.Add(SI_port_txt);
            ServerInfoTab.Controls.Add(SI_port_lbl);
            ServerInfoTab.Controls.Add(SI_ip_txt);
            ServerInfoTab.Controls.Add(SI_ip_lbl);
            ServerInfoTab.Location = new Point(4, 24);
            ServerInfoTab.Name = "ServerInfoTab";
            ServerInfoTab.Size = new Size(792, 263);
            ServerInfoTab.TabIndex = 2;
            ServerInfoTab.Text = TabContentResource.ServerInfoTabTitle;
            ServerInfoTab.UseVisualStyleBackColor = true;
            // 
            // SI_reload_btn
            // 
            SI_reload_btn.Location = new Point(612, 227);
            SI_reload_btn.Name = "SI_reload_btn";
            SI_reload_btn.Size = new Size(172, 23);
            SI_reload_btn.TabIndex = 14;
            SI_reload_btn.Text = "Refresh";
            SI_reload_btn.UseVisualStyleBackColor = true;
            SI_reload_btn.Click += SI_reload_btn_Click;
            // 
            // SI_logreq_chk
            // 
            SI_logreq_chk.AutoSize = true;
            SI_logreq_chk.Location = new Point(175, 143);
            SI_logreq_chk.Name = "SI_logreq_chk";
            SI_logreq_chk.Size = new Size(15, 14);
            SI_logreq_chk.TabIndex = 13;
            SI_logreq_chk.UseVisualStyleBackColor = true;
            // 
            // SI_logreq_lbl
            // 
            SI_logreq_lbl.AutoSize = true;
            SI_logreq_lbl.Location = new Point(8, 143);
            SI_logreq_lbl.Name = "SI_logreq_lbl";
            SI_logreq_lbl.Size = new Size(77, 15);
            SI_logreq_lbl.TabIndex = 11;
            SI_logreq_lbl.Text = "Log Requests";
            SI_logreq_lbl.Click += SI_logreq_lbl_Click;
            // 
            // SI_wsdelay_txt
            // 
            SI_wsdelay_txt.Location = new Point(175, 111);
            SI_wsdelay_txt.Name = "SI_wsdelay_txt";
            SI_wsdelay_txt.Size = new Size(175, 23);
            SI_wsdelay_txt.TabIndex = 10;
            // 
            // SI_wsdelay_lbl
            // 
            SI_wsdelay_lbl.AutoSize = true;
            SI_wsdelay_lbl.Location = new Point(8, 114);
            SI_wsdelay_lbl.Name = "SI_wsdelay_lbl";
            SI_wsdelay_lbl.Size = new Size(152, 15);
            SI_wsdelay_lbl.TabIndex = 9;
            SI_wsdelay_lbl.Text = "WebSocket Ping Delay (ms)";
            SI_wsdelay_lbl.Click += SI_wsdelay_lbl_Click;
            // 
            // SI_beport_txt
            // 
            SI_beport_txt.Location = new Point(603, 40);
            SI_beport_txt.Name = "SI_beport_txt";
            SI_beport_txt.Size = new Size(175, 23);
            SI_beport_txt.TabIndex = 8;
            // 
            // SI_beport_lbl
            // 
            SI_beport_lbl.AutoSize = true;
            SI_beport_lbl.Location = new Point(436, 43);
            SI_beport_lbl.Name = "SI_beport_lbl";
            SI_beport_lbl.Size = new Size(77, 15);
            SI_beport_lbl.TabIndex = 7;
            SI_beport_lbl.Text = "Backend Port";
            SI_beport_lbl.Click += SI_beport_lbl_Click;
            // 
            // SI_beip_txt
            // 
            SI_beip_txt.Location = new Point(603, 11);
            SI_beip_txt.Name = "SI_beip_txt";
            SI_beip_txt.Size = new Size(175, 23);
            SI_beip_txt.TabIndex = 6;
            // 
            // SI_beip_lbl
            // 
            SI_beip_lbl.AutoSize = true;
            SI_beip_lbl.Location = new Point(436, 14);
            SI_beip_lbl.Name = "SI_beip_lbl";
            SI_beip_lbl.Size = new Size(65, 15);
            SI_beip_lbl.TabIndex = 5;
            SI_beip_lbl.Text = "Backend IP";
            SI_beip_lbl.Click += SI_beip_lbl_Click;
            // 
            // SI_port_txt
            // 
            SI_port_txt.Location = new Point(175, 40);
            SI_port_txt.Name = "SI_port_txt";
            SI_port_txt.Size = new Size(175, 23);
            SI_port_txt.TabIndex = 4;
            // 
            // SI_port_lbl
            // 
            SI_port_lbl.AutoSize = true;
            SI_port_lbl.Location = new Point(8, 43);
            SI_port_lbl.Name = "SI_port_lbl";
            SI_port_lbl.Size = new Size(29, 15);
            SI_port_lbl.TabIndex = 3;
            SI_port_lbl.Text = "Port";
            SI_port_lbl.Click += SI_port_lbl_Click;
            // 
            // SI_ip_txt
            // 
            SI_ip_txt.Location = new Point(175, 11);
            SI_ip_txt.Name = "SI_ip_txt";
            SI_ip_txt.Size = new Size(175, 23);
            SI_ip_txt.TabIndex = 2;
            // 
            // SI_ip_lbl
            // 
            SI_ip_lbl.AutoSize = true;
            SI_ip_lbl.Location = new Point(8, 14);
            SI_ip_lbl.Name = "SI_ip_lbl";
            SI_ip_lbl.Size = new Size(68, 15);
            SI_ip_lbl.TabIndex = 1;
            SI_ip_lbl.Text = "IP test hehe";
            SI_ip_lbl.Click += SI_ip_lbl_Click;
            // 
            // LauncherInfoTab
            // 
            LauncherInfoTab.Controls.Add(LI_reload_btn);
            LauncherInfoTab.Controls.Add(LI_defaultlocale_txt);
            LauncherInfoTab.Controls.Add(LI_defaultlocale_lbl);
            LauncherInfoTab.Controls.Add(LI_serverurl_txt);
            LauncherInfoTab.Controls.Add(LI_filepath_txt);
            LauncherInfoTab.Controls.Add(LI_servername_txt);
            LauncherInfoTab.Controls.Add(LI_firstrun_chk);
            LauncherInfoTab.Controls.Add(LI_filepath_lbl);
            LauncherInfoTab.Controls.Add(LI_serverurl_lbl);
            LauncherInfoTab.Controls.Add(LI_servername_lbl);
            LauncherInfoTab.Controls.Add(LI_firstrun_lbl);
            LauncherInfoTab.Controls.Add(LI_useAutoLogin_chk);
            LauncherInfoTab.Controls.Add(LI_password_txt);
            LauncherInfoTab.Controls.Add(LI_password_lbl);
            LauncherInfoTab.Controls.Add(LI_username_txt);
            LauncherInfoTab.Controls.Add(LI_username_lbl);
            LauncherInfoTab.Controls.Add(LI_useAutoLogin_lbl);
            LauncherInfoTab.Location = new Point(4, 24);
            LauncherInfoTab.Name = "LauncherInfoTab";
            LauncherInfoTab.Size = new Size(792, 263);
            LauncherInfoTab.TabIndex = 3;
            LauncherInfoTab.Text = TabContentResource.LauncherInfoTabTitle;
            LauncherInfoTab.UseVisualStyleBackColor = true;
            // 
            // LI_reload_btn
            // 
            LI_reload_btn.Location = new Point(612, 227);
            LI_reload_btn.Name = "LI_reload_btn";
            LI_reload_btn.Size = new Size(172, 23);
            LI_reload_btn.TabIndex = 24;
            LI_reload_btn.Text = "Refresh";
            LI_reload_btn.UseVisualStyleBackColor = true;
            LI_reload_btn.Click += LI_reload_btn_Click;
            // 
            // LI_defaultlocale_txt
            // 
            LI_defaultlocale_txt.Location = new Point(603, 40);
            LI_defaultlocale_txt.Name = "LI_defaultlocale_txt";
            LI_defaultlocale_txt.Size = new Size(175, 23);
            LI_defaultlocale_txt.TabIndex = 23;
            // 
            // LI_defaultlocale_lbl
            // 
            LI_defaultlocale_lbl.AutoSize = true;
            LI_defaultlocale_lbl.Location = new Point(436, 43);
            LI_defaultlocale_lbl.Name = "LI_defaultlocale_lbl";
            LI_defaultlocale_lbl.Size = new Size(82, 15);
            LI_defaultlocale_lbl.TabIndex = 22;
            LI_defaultlocale_lbl.Text = "Default Locale";
            LI_defaultlocale_lbl.Click += LI_defaultlocale_lbl_Click;
            // 
            // LI_serverurl_txt
            // 
            LI_serverurl_txt.Location = new Point(8, 184);
            LI_serverurl_txt.Name = "LI_serverurl_txt";
            LI_serverurl_txt.Size = new Size(500, 23);
            LI_serverurl_txt.TabIndex = 21;
            // 
            // LI_filepath_txt
            // 
            LI_filepath_txt.Location = new Point(8, 133);
            LI_filepath_txt.Name = "LI_filepath_txt";
            LI_filepath_txt.Size = new Size(500, 23);
            LI_filepath_txt.TabIndex = 20;
            // 
            // LI_servername_txt
            // 
            LI_servername_txt.Location = new Point(603, 69);
            LI_servername_txt.Name = "LI_servername_txt";
            LI_servername_txt.Size = new Size(175, 23);
            LI_servername_txt.TabIndex = 19;
            // 
            // LI_firstrun_chk
            // 
            LI_firstrun_chk.AutoSize = true;
            LI_firstrun_chk.Location = new Point(603, 14);
            LI_firstrun_chk.Name = "LI_firstrun_chk";
            LI_firstrun_chk.Size = new Size(15, 14);
            LI_firstrun_chk.TabIndex = 18;
            LI_firstrun_chk.UseVisualStyleBackColor = true;
            // 
            // LI_filepath_lbl
            // 
            LI_filepath_lbl.AutoSize = true;
            LI_filepath_lbl.Location = new Point(8, 115);
            LI_filepath_lbl.Name = "LI_filepath_lbl";
            LI_filepath_lbl.Size = new Size(65, 15);
            LI_filepath_lbl.TabIndex = 16;
            LI_filepath_lbl.Text = "Game Path";
            LI_filepath_lbl.Click += LI_filepath_lbl_Click;
            // 
            // LI_serverurl_lbl
            // 
            LI_serverurl_lbl.AutoSize = true;
            LI_serverurl_lbl.Location = new Point(8, 166);
            LI_serverurl_lbl.Name = "LI_serverurl_lbl";
            LI_serverurl_lbl.Size = new Size(57, 15);
            LI_serverurl_lbl.TabIndex = 14;
            LI_serverurl_lbl.Text = "Server Url";
            LI_serverurl_lbl.Click += LI_serverurl_lbl_Click;
            // 
            // LI_servername_lbl
            // 
            LI_servername_lbl.AutoSize = true;
            LI_servername_lbl.Location = new Point(436, 72);
            LI_servername_lbl.Name = "LI_servername_lbl";
            LI_servername_lbl.Size = new Size(74, 15);
            LI_servername_lbl.TabIndex = 12;
            LI_servername_lbl.Text = "Server Name";
            LI_servername_lbl.Click += LI_servername_lbl_Click;
            // 
            // LI_firstrun_lbl
            // 
            LI_firstrun_lbl.AutoSize = true;
            LI_firstrun_lbl.Location = new Point(436, 14);
            LI_firstrun_lbl.Name = "LI_firstrun_lbl";
            LI_firstrun_lbl.Size = new Size(86, 15);
            LI_firstrun_lbl.TabIndex = 10;
            LI_firstrun_lbl.Text = "First Run Setup";
            LI_firstrun_lbl.Click += LI_firstrun_lbl_Click;
            // 
            // LI_useAutoLogin_chk
            // 
            LI_useAutoLogin_chk.AutoSize = true;
            LI_useAutoLogin_chk.Location = new Point(175, 14);
            LI_useAutoLogin_chk.Name = "LI_useAutoLogin_chk";
            LI_useAutoLogin_chk.Size = new Size(15, 14);
            LI_useAutoLogin_chk.TabIndex = 9;
            LI_useAutoLogin_chk.UseVisualStyleBackColor = true;
            // 
            // LI_password_txt
            // 
            LI_password_txt.Location = new Point(175, 69);
            LI_password_txt.Name = "LI_password_txt";
            LI_password_txt.Size = new Size(175, 23);
            LI_password_txt.TabIndex = 8;
            // 
            // LI_password_lbl
            // 
            LI_password_lbl.AutoSize = true;
            LI_password_lbl.Location = new Point(8, 72);
            LI_password_lbl.Name = "LI_password_lbl";
            LI_password_lbl.Size = new Size(57, 15);
            LI_password_lbl.TabIndex = 6;
            LI_password_lbl.Text = "Password";
            LI_password_lbl.Click += LI_password_lbl_Click;
            // 
            // LI_username_txt
            // 
            LI_username_txt.Location = new Point(175, 40);
            LI_username_txt.Name = "LI_username_txt";
            LI_username_txt.Size = new Size(175, 23);
            LI_username_txt.TabIndex = 5;
            // 
            // LI_username_lbl
            // 
            LI_username_lbl.AutoSize = true;
            LI_username_lbl.Location = new Point(8, 43);
            LI_username_lbl.Name = "LI_username_lbl";
            LI_username_lbl.Size = new Size(60, 15);
            LI_username_lbl.TabIndex = 4;
            LI_username_lbl.Text = "Username";
            LI_username_lbl.Click += LI_username_lbl_Click;
            // 
            // LI_useAutoLogin_lbl
            // 
            LI_useAutoLogin_lbl.AutoSize = true;
            LI_useAutoLogin_lbl.Location = new Point(8, 14);
            LI_useAutoLogin_lbl.Name = "LI_useAutoLogin_lbl";
            LI_useAutoLogin_lbl.Size = new Size(88, 15);
            LI_useAutoLogin_lbl.TabIndex = 2;
            LI_useAutoLogin_lbl.Text = "Use Auto Login";
            LI_useAutoLogin_lbl.Click += LI_useAutoLogin_lbl_Click;
            // 
            // ProfilesTab
            // 
            ProfilesTab.Controls.Add(profile_tab_import_btn);
            ProfilesTab.Controls.Add(profile_tab_open_profile_btn);
            ProfilesTab.Controls.Add(profile_tab_refresh_btn);
            ProfilesTab.Controls.Add(profile_tab_export_btn);
            ProfilesTab.Controls.Add(profile_tab_open_game_btn);
            ProfilesTab.Controls.Add(profile_tab_profilefile_lbl);
            ProfilesTab.Controls.Add(profile_tab_gamefile_lbl);
            ProfilesTab.Controls.Add(profile_tab_profilefiles_lbox);
            ProfilesTab.Controls.Add(profile_tab_gamefiles_lbox);
            ProfilesTab.Location = new Point(4, 24);
            ProfilesTab.Name = "ProfilesTab";
            ProfilesTab.Size = new Size(792, 263);
            ProfilesTab.TabIndex = 4;
            ProfilesTab.Text = TabContentResource.ProfilesTabTitle;
            ProfilesTab.UseVisualStyleBackColor = true;
            // 
            // profile_tab_import_btn
            // 
            profile_tab_import_btn.Location = new Point(612, 198);
            profile_tab_import_btn.Name = "profile_tab_import_btn";
            profile_tab_import_btn.Size = new Size(172, 23);
            profile_tab_import_btn.TabIndex = 13;
            profile_tab_import_btn.Text = "ProfileTabResource.ImportFromProfile";
            profile_tab_import_btn.UseVisualStyleBackColor = true;
            // 
            // profile_tab_open_profile_btn
            // 
            profile_tab_open_profile_btn.Location = new Point(612, 169);
            profile_tab_open_profile_btn.Name = "profile_tab_open_profile_btn";
            profile_tab_open_profile_btn.Size = new Size(172, 23);
            profile_tab_open_profile_btn.TabIndex = 12;
            profile_tab_open_profile_btn.Text = "ProfileTabResource.OpenProfileFiles";
            profile_tab_open_profile_btn.UseVisualStyleBackColor = true;
            // 
            // profile_tab_refresh_btn
            // 
            profile_tab_refresh_btn.Location = new Point(612, 111);
            profile_tab_refresh_btn.Name = "profile_tab_refresh_btn";
            profile_tab_refresh_btn.Size = new Size(172, 23);
            profile_tab_refresh_btn.TabIndex = 11;
            profile_tab_refresh_btn.Text = "ProfileTabResource.Refresh";
            profile_tab_refresh_btn.UseVisualStyleBackColor = true;
            // 
            // profile_tab_export_btn
            // 
            profile_tab_export_btn.Location = new Point(612, 227);
            profile_tab_export_btn.Name = "profile_tab_export_btn";
            profile_tab_export_btn.Size = new Size(172, 23);
            profile_tab_export_btn.TabIndex = 10;
            profile_tab_export_btn.Text = "ProfileTabResource.ExportProfile";
            profile_tab_export_btn.UseVisualStyleBackColor = true;
            // 
            // profile_tab_open_game_btn
            // 
            profile_tab_open_game_btn.Location = new Point(612, 140);
            profile_tab_open_game_btn.Name = "profile_tab_open_game_btn";
            profile_tab_open_game_btn.Size = new Size(172, 23);
            profile_tab_open_game_btn.TabIndex = 9;
            profile_tab_open_game_btn.Text = "ProfileTabResource.OpenGameFiles";
            profile_tab_open_game_btn.UseVisualStyleBackColor = true;
            profile_tab_open_game_btn.Click += profile_tab_open_game_btn_Click;
            // 
            // profile_tab_profilefile_lbl
            // 
            profile_tab_profilefile_lbl.AutoSize = true;
            profile_tab_profilefile_lbl.Location = new Point(306, 18);
            profile_tab_profilefile_lbl.Name = "profile_tab_profilefile_lbl";
            profile_tab_profilefile_lbl.Size = new Size(67, 15);
            profile_tab_profilefile_lbl.TabIndex = 7;
            profile_tab_profilefile_lbl.Text = "Profile Files";
            // 
            // profile_tab_gamefile_lbl
            // 
            profile_tab_gamefile_lbl.AutoSize = true;
            profile_tab_gamefile_lbl.Location = new Point(3, 18);
            profile_tab_gamefile_lbl.Name = "profile_tab_gamefile_lbl";
            profile_tab_gamefile_lbl.Size = new Size(64, 15);
            profile_tab_gamefile_lbl.TabIndex = 6;
            profile_tab_gamefile_lbl.Text = "Game Files";
            // 
            // profile_tab_profilefiles_lbox
            // 
            profile_tab_profilefiles_lbox.FormattingEnabled = true;
            profile_tab_profilefiles_lbox.ItemHeight = 15;
            profile_tab_profilefiles_lbox.Location = new Point(309, 36);
            profile_tab_profilefiles_lbox.Name = "profile_tab_profilefiles_lbox";
            profile_tab_profilefiles_lbox.Size = new Size(297, 214);
            profile_tab_profilefiles_lbox.TabIndex = 1;
            // 
            // profile_tab_gamefiles_lbox
            // 
            profile_tab_gamefiles_lbox.FormattingEnabled = true;
            profile_tab_gamefiles_lbox.ItemHeight = 15;
            profile_tab_gamefiles_lbox.Location = new Point(6, 36);
            profile_tab_gamefiles_lbox.Name = "profile_tab_gamefiles_lbox";
            profile_tab_gamefiles_lbox.Size = new Size(297, 214);
            profile_tab_gamefiles_lbox.TabIndex = 0;
            // 
            // serverHttpConfigurationFileBindingSource
            // 
            serverHttpConfigurationFileBindingSource.DataSource = typeof(Models.ServerHttpConfigurationFile);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Active Profile";
            // 
            // ProfileLinkLabel
            // 
            ProfileLinkLabel.AutoSize = true;
            ProfileLinkLabel.Location = new Point(5, 47);
            ProfileLinkLabel.Name = "ProfileLinkLabel";
            ProfileLinkLabel.Size = new Size(102, 15);
            ProfileLinkLabel.TabIndex = 4;
            ProfileLinkLabel.Text = "No Profile Loaded";
            // 
            // fika_client_status_lbl
            // 
            fika_client_status_lbl.AutoSize = true;
            fika_client_status_lbl.Location = new Point(705, 57);
            fika_client_status_lbl.Name = "fika_client_status_lbl";
            fika_client_status_lbl.Size = new Size(64, 15);
            fika_client_status_lbl.TabIndex = 5;
            fika_client_status_lbl.Text = "Not Found";
            // 
            // fika_server_status_lbl
            // 
            fika_server_status_lbl.AutoSize = true;
            fika_server_status_lbl.Location = new Point(705, 39);
            fika_server_status_lbl.Name = "fika_server_status_lbl";
            fika_server_status_lbl.Size = new Size(64, 15);
            fika_server_status_lbl.TabIndex = 6;
            fika_server_status_lbl.Text = "Not Found";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 57);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 7;
            label4.Text = "Fika Server Version:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 39);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 8;
            label2.Text = "Fika Client Version:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // bep_tab_openprofilefile_btn_tt
            // 
            bep_tab_openprofilefile_btn_tt.AutoPopDelay = 5000;
            bep_tab_openprofilefile_btn_tt.InitialDelay = 100;
            bep_tab_openprofilefile_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_opengamefile_btn_tt
            // 
            bep_tab_opengamefile_btn_tt.AutoPopDelay = 5000;
            bep_tab_opengamefile_btn_tt.InitialDelay = 100;
            bep_tab_opengamefile_btn_tt.ReshowDelay = 100;
            // 
            // bep_list_helper_2_tt
            // 
            bep_list_helper_2_tt.AutoPopDelay = 5000;
            bep_list_helper_2_tt.InitialDelay = 100;
            bep_list_helper_2_tt.ReshowDelay = 100;
            // 
            // bep_list_helper_1_tt
            // 
            bep_list_helper_1_tt.AutoPopDelay = 5000;
            bep_list_helper_1_tt.InitialDelay = 100;
            bep_list_helper_1_tt.ReshowDelay = 100;
            // 
            // bep_tab_refresh_btn_tt
            // 
            bep_tab_refresh_btn_tt.AutoPopDelay = 5000;
            bep_tab_refresh_btn_tt.InitialDelay = 100;
            bep_tab_refresh_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_exportall_btn_tt
            // 
            bep_tab_exportall_btn_tt.AutoPopDelay = 5000;
            bep_tab_exportall_btn_tt.InitialDelay = 100;
            bep_tab_exportall_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_importselected_btn_tt
            // 
            bep_tab_importselected_btn_tt.AutoPopDelay = 5000;
            bep_tab_importselected_btn_tt.InitialDelay = 100;
            bep_tab_importselected_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_exportselected_btn_tt
            // 
            bep_tab_exportselected_btn_tt.AutoPopDelay = 5000;
            bep_tab_exportselected_btn_tt.InitialDelay = 100;
            bep_tab_exportselected_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_importall_btn_tt
            // 
            bep_tab_importall_btn_tt.AutoPopDelay = 5000;
            bep_tab_importall_btn_tt.InitialDelay = 100;
            bep_tab_importall_btn_tt.ReshowDelay = 100;
            // 
            // bep_tab_info_btn_tt
            // 
            bep_tab_info_btn_tt.AutoPopDelay = 5000;
            bep_tab_info_btn_tt.InitialDelay = 100;
            bep_tab_info_btn_tt.ReshowDelay = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(fika_server_status_lbl);
            Controls.Add(fika_client_status_lbl);
            Controls.Add(ProfileLinkLabel);
            Controls.Add(label1);
            Controls.Add(mainMenuTabs);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "playtarky";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainMenuTabs.ResumeLayout(false);
            bepInExPluginsTab.ResumeLayout(false);
            bepInExPluginsTab.PerformLayout();
            UserModsTab.ResumeLayout(false);
            UserModsTab.PerformLayout();
            ServerInfoTab.ResumeLayout(false);
            ServerInfoTab.PerformLayout();
            LauncherInfoTab.ResumeLayout(false);
            LauncherInfoTab.PerformLayout();
            ProfilesTab.ResumeLayout(false);
            ProfilesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serverHttpConfigurationFileBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openProfileToolStripMenuItem;
        private ToolStripMenuItem saveProfileAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip statusStrip1;
        public ToolStripProgressBar progressBar;
        public ToolStripStatusLabel progressStatusText;
        private TabControl mainMenuTabs;
        private TabPage bepInExPluginsTab;
        private TabPage UserModsTab;
        private TabPage ServerInfoTab;
        private TabPage LauncherInfoTab;
        private Label label1;
        private Label label2;
        private Label ProfileLinkLabel;
        private ListBox bep_tab_gamefiles_lbox;
        private ListBox user_tab_gamefiles_lbox;
        private ToolStripMenuItem saveProfileToolStripMenuItem;
        private Button user_tab_export_btn;
        private Button user_tab_open_game_btn;
        private TabPage ProfilesTab;
        private Button user_tab_refresh_btn;
        private Label bep_tab_profilefile_lbl;
        private Label bep_tab_gamefile_lbl;
        private ListBox bep_tab_profilefiles_lbox;
        private Label fika_client_status_lbl;
        private Label fika_server_status_lbl;
        private Label label4;
        private ListBox user_tab_profilefiles_lbox;
        private Label user_tab_gamefile_lbl;
        private Button user_tab_open_profile_btn;
        private Button user_tab_import_btn;
        private Label user_tab_profilefile_lbl;
        private CheckBox SI_logreq_chk;
        private Label SI_logreq_lbl;
        private TextBox SI_wsdelay_txt;
        private Label SI_wsdelay_lbl;
        private TextBox SI_beport_txt;
        private Label SI_beport_lbl;
        private TextBox SI_beip_txt;
        private Label SI_beip_lbl;
        private TextBox SI_port_txt;
        private Label SI_port_lbl;
        private TextBox SI_ip_txt;
        private Label SI_ip_lbl;
        private BindingSource serverHttpConfigurationFileBindingSource;
        private CheckBox LI_useAutoLogin_chk;
        private MaskedTextBox LI_password_txt;
        private Label LI_password_lbl;
        private TextBox LI_username_txt;
        private Label LI_username_lbl;
        private Label LI_useAutoLogin_lbl;
        private MaskedTextBox maskedTextBox2;
        private Label LI_servername_lbl;
        private Label LI_firstrun_lbl;
        private CheckBox LI_firstrun_chk;
        private MaskedTextBox maskedTextBox4;
        private Label LI_filepath_lbl;
        private MaskedTextBox maskedTextBox3;
        private Label LI_serverurl_lbl;
        private TextBox LI_serverurl_txt;
        private TextBox LI_filepath_txt;
        private TextBox LI_servername_txt;
        private TextBox LI_defaultlocale_txt;
        private Label LI_defaultlocale_lbl;
        private Button SI_reload_btn;
        private Button LI_reload_btn;
        private Button profile_tab_import_btn;
        private Button profile_tab_open_profile_btn;
        private Button profile_tab_refresh_btn;
        private Button profile_tab_export_btn;
        private Button profile_tab_open_game_btn;
        private Label profile_tab_profilefile_lbl;
        private Label profile_tab_gamefile_lbl;
        private ListBox profile_tab_profilefiles_lbox;
        private ListBox profile_tab_gamefiles_lbox;
        private ToolStripStatusLabel spt_version_lbl;
        private Button bep_tab_refresh_btn;
        private Button bep_tab_openprofilefile_btn;
        private Button bep_tab_opengamefile_btn;
        private Button bep_tab_exportselected_btn;
        private Button bep_tab_importall_btn;
        private Button bep_tab_exportall_btn;
        private Button bep_tab_importselected_btn;
        private ToolTip bep_tab_openprofilefile_btn_tt;
        private ToolTip bep_tab_opengamefile_btn_tt;
        private ToolTip bep_list_helper_2_tt;
        private ToolTip bep_list_helper_1_tt;
        private ToolTip bep_tab_refresh_btn_tt;
        private ToolTip bep_tab_exportall_btn_tt;
        private ToolTip bep_tab_importselected_btn_tt;
        private ToolTip bep_tab_exportselected_btn_tt;
        private ToolTip bep_tab_importall_btn_tt;
        private Button bep_tab_info_btn;
        private ToolTip bep_tab_info_btn_tt;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace playtarky
{
    public partial class Form1 : Form
    {
        //TODO: err and not load if install is not found
        //TODO: Normalize gamedir

        public List<string> profile_list = new List<string>();
        public string active_profile = string.Empty;

        public Form1()
        {
            InitializeComponent();
            InitializeProgram();



            InitializeFikaStatus();

            //Initialize files
            InitializeTabBep();
            //InitializeTabUser();
            //InitializeTabServer();
            //InitializeTabLauncher();
            //InitializeTabProfiles();
        }

        private void InitializeProgram()
        {
            //First run
            //if (!Directory.Exists("C:\\SPT\\modprofiler"))
            //{
            //    Directory.CreateDirectory("C:\\SPT\\modprofiler");
            //}

            //if (Directory.GetDirectories("C:\\SPT\\modprofiler").Length == 0)
            //{
            //    DialogResult result = MessageBox.Show("No profile has been found. Would you like to you create one with the current game data?", "No profile found", MessageBoxButtons.YesNo);

            //    if (result == DialogResult.Yes)
            //    {
            //        // User clicked Yes
            //        // Add your logic here for the Yes option
            //    }
            //}
        }

        private List<string> getProfiles()
        {
            profile_list.Clear();
            foreach (var dir in Directory.GetDirectories("C:\\SPT"))
            {
                profile_list.Add(dir.Substring(dir.LastIndexOf('\\') + 1));
            }
            return profile_list;
        }



        private void InitializeFikaStatus()
        {
            //TODO: Get Server version in C:\Fika\user\mods\fika-server\package.json if found.
            //TODO: Get Client version in C:\Fika\BepInEx\plugins\fika.core.dll meta data file version if found.
        }

        #region Tab BepExIn
        private void InitializeTabBep()
        {
            //buttons
            Toggle_Field_For_Profile_Activity(!String.IsNullOrWhiteSpace(active_profile));

            var bepInExDirList = Directory.GetDirectories("C:\\SPT\\BepInEx\\plugins").ToList();
            var bepInExFileList = Directory.GetFiles("C:\\SPT\\BepInEx\\plugins").ToList();

            bepInExGameFiles.Items.Clear();
            foreach (var item in bepInExDirList)
                bepInExGameFiles.Items.Add(string.Concat(item.AsSpan(item.LastIndexOf('\\') + 1), "\\"));

            foreach (var item in bepInExFileList)
                bepInExGameFiles.Items.Add(item.Substring(item.LastIndexOf('\\') + 1));
        }

        private void refresh_bep_btn_Click(object sender, EventArgs e)
        {
            InitializeTabBep();
        }

        private void open_profile_bep_btn_Click(object sender, EventArgs e)
        {
            //TODO: TO DO
            MessageBox.Show("NOT IMPLEMENTED");
        }

        private void open_bep_btn_Click(object sender, EventArgs e)
        {
            //TODO: File Path
            Process.Start("explorer.exe", "C:\\SPT\\BepInEx");
        }

        private void import_bep_btn_Click(object sender, EventArgs e)
        {

        }

        private void export_bep_btn_Click(object sender, EventArgs e)
        {
            //TODO: TO DO
            MessageBox.Show("NOT IMPLEMENTED");
        }
        #endregion

        #region menu strip
        private void InitializeProfiles()
        {
            var list = getProfiles();

            openProfileToolStripMenuItem.DropDownItems.Clear();
            foreach (var dir in list)
            {
                var itemText = dir.Substring(dir.LastIndexOf('\\') + 1);
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(itemText);
                toolStripMenuItem.Click += (sender, e) => ImportProfileItem_Click(sender, e, itemText);
                openProfileToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
            }

            if (list.Count == 0)
            {
                openProfileToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Empty")
                {
                    Enabled = false
                });
            }
        }

        static void ImportProfileItem_Click(object sender, EventArgs e, string menuItemText)
        {
            //TODO: TO DO
            MessageBox.Show("Clicked: " + menuItemText);
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeProfiles();
        }
        #endregion

        private void Toggle_Field_For_Profile_Activity(bool isActive)
        {
            //Bep Tab
            export_bep_btn.Enabled = isActive;
            import_bep_btn.Enabled = isActive;
            bep_profileFiles_label.Enabled = isActive;
            bepInExProfileFiles.Enabled = isActive;
            open_profile_bep_btn.Enabled = isActive;
        }


    }
}
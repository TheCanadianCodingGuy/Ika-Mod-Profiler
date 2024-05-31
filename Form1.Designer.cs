namespace playtarky
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileToolStripMenuItem = new ToolStripMenuItem();
            saveProfileAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            progressBar = new ToolStripProgressBar();
            progressStatusText = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            ServerModsTab = new TabPage();
            import_bep_btn = new Button();
            open_profile_bep_btn = new Button();
            bep_profileFiles_label = new Label();
            label3 = new Label();
            bepInExProfileFiles = new ListBox();
            refresh_bep_btn = new Button();
            export_bep_btn = new Button();
            open_game_bep_btn = new Button();
            bepInExGameFiles = new ListBox();
            UserModsTab = new TabPage();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            userModsFiles = new ListBox();
            ServerInfoTab = new TabPage();
            LauncherInfoTab = new TabPage();
            ProfilesTab = new TabPage();
            label1 = new Label();
            ProfileLinkLabel = new Label();
            fika_client_status_lbl = new Label();
            fika_server_status_lbl = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            ServerModsTab.SuspendLayout();
            UserModsTab.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openProfileToolStripMenuItem, saveProfileToolStripMenuItem, saveProfileAsToolStripMenuItem, toolStripSeparator1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += FileToolStripMenuItem_Click;
            // 
            // openProfileToolStripMenuItem
            // 
            openProfileToolStripMenuItem.Name = "openProfileToolStripMenuItem";
            openProfileToolStripMenuItem.Size = new Size(190, 22);
            openProfileToolStripMenuItem.Text = "Open Profile...";
            // 
            // saveProfileToolStripMenuItem
            // 
            saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            saveProfileToolStripMenuItem.Size = new Size(190, 22);
            saveProfileToolStripMenuItem.Text = "Save to current profile";
            // 
            // saveProfileAsToolStripMenuItem
            // 
            saveProfileAsToolStripMenuItem.Name = "saveProfileAsToolStripMenuItem";
            saveProfileAsToolStripMenuItem.Size = new Size(190, 22);
            saveProfileAsToolStripMenuItem.Text = "Save Profile As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { progressBar, progressStatusText });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 16);
            // 
            // progressStatusText
            // 
            progressStatusText.Name = "progressStatusText";
            progressStatusText.Size = new Size(0, 17);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ServerModsTab);
            tabControl1.Controls.Add(UserModsTab);
            tabControl1.Controls.Add(ServerInfoTab);
            tabControl1.Controls.Add(LauncherInfoTab);
            tabControl1.Controls.Add(ProfilesTab);
            tabControl1.Location = new Point(0, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 291);
            tabControl1.TabIndex = 2;
            // 
            // ServerModsTab
            // 
            ServerModsTab.Controls.Add(import_bep_btn);
            ServerModsTab.Controls.Add(open_profile_bep_btn);
            ServerModsTab.Controls.Add(bep_profileFiles_label);
            ServerModsTab.Controls.Add(label3);
            ServerModsTab.Controls.Add(bepInExProfileFiles);
            ServerModsTab.Controls.Add(refresh_bep_btn);
            ServerModsTab.Controls.Add(export_bep_btn);
            ServerModsTab.Controls.Add(open_game_bep_btn);
            ServerModsTab.Controls.Add(bepInExGameFiles);
            ServerModsTab.Location = new Point(4, 24);
            ServerModsTab.Name = "ServerModsTab";
            ServerModsTab.Padding = new Padding(3);
            ServerModsTab.Size = new Size(792, 263);
            ServerModsTab.TabIndex = 0;
            ServerModsTab.Text = "BepInEx";
            ServerModsTab.UseVisualStyleBackColor = true;
            // 
            // import_bep_btn
            // 
            import_bep_btn.Location = new Point(612, 198);
            import_bep_btn.Name = "import_bep_btn";
            import_bep_btn.Size = new Size(172, 23);
            import_bep_btn.TabIndex = 8;
            import_bep_btn.Text = "Import from active profile";
            import_bep_btn.UseVisualStyleBackColor = true;
            import_bep_btn.Click += import_bep_btn_Click;
            // 
            // open_profile_bep_btn
            // 
            open_profile_bep_btn.Location = new Point(612, 169);
            open_profile_bep_btn.Name = "open_profile_bep_btn";
            open_profile_bep_btn.Size = new Size(172, 23);
            open_profile_bep_btn.TabIndex = 7;
            open_profile_bep_btn.Text = "Open profile files in explorer";
            open_profile_bep_btn.UseVisualStyleBackColor = true;
            open_profile_bep_btn.Click += open_profile_bep_btn_Click;
            // 
            // bep_profileFiles_label
            // 
            bep_profileFiles_label.AutoSize = true;
            bep_profileFiles_label.Location = new Point(306, 18);
            bep_profileFiles_label.Name = "bep_profileFiles_label";
            bep_profileFiles_label.Size = new Size(67, 15);
            bep_profileFiles_label.TabIndex = 6;
            bep_profileFiles_label.Text = "Profile Files";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Game Files";
            // 
            // bepInExProfileFiles
            // 
            bepInExProfileFiles.FormattingEnabled = true;
            bepInExProfileFiles.ItemHeight = 15;
            bepInExProfileFiles.Location = new Point(309, 36);
            bepInExProfileFiles.Name = "bepInExProfileFiles";
            bepInExProfileFiles.Size = new Size(297, 214);
            bepInExProfileFiles.TabIndex = 4;
            // 
            // refresh_bep_btn
            // 
            refresh_bep_btn.Location = new Point(612, 111);
            refresh_bep_btn.Name = "refresh_bep_btn";
            refresh_bep_btn.Size = new Size(172, 23);
            refresh_bep_btn.TabIndex = 3;
            refresh_bep_btn.Text = "Refresh";
            refresh_bep_btn.UseVisualStyleBackColor = true;
            refresh_bep_btn.Click += refresh_bep_btn_Click;
            // 
            // export_bep_btn
            // 
            export_bep_btn.Location = new Point(612, 227);
            export_bep_btn.Name = "export_bep_btn";
            export_bep_btn.Size = new Size(172, 23);
            export_bep_btn.TabIndex = 2;
            export_bep_btn.Text = "Export to active profile";
            export_bep_btn.UseVisualStyleBackColor = true;
            export_bep_btn.Click += export_bep_btn_Click;
            // 
            // open_game_bep_btn
            // 
            open_game_bep_btn.Location = new Point(612, 140);
            open_game_bep_btn.Name = "open_game_bep_btn";
            open_game_bep_btn.Size = new Size(172, 23);
            open_game_bep_btn.TabIndex = 1;
            open_game_bep_btn.Text = "Open game files in explorer";
            open_game_bep_btn.UseVisualStyleBackColor = true;
            open_game_bep_btn.Click += open_bep_btn_Click;
            // 
            // bepInExGameFiles
            // 
            bepInExGameFiles.FormattingEnabled = true;
            bepInExGameFiles.ItemHeight = 15;
            bepInExGameFiles.Location = new Point(6, 36);
            bepInExGameFiles.Name = "bepInExGameFiles";
            bepInExGameFiles.Size = new Size(297, 214);
            bepInExGameFiles.TabIndex = 0;
            // 
            // UserModsTab
            // 
            UserModsTab.Controls.Add(button5);
            UserModsTab.Controls.Add(button4);
            UserModsTab.Controls.Add(listBox1);
            UserModsTab.Controls.Add(label5);
            UserModsTab.Controls.Add(button3);
            UserModsTab.Controls.Add(button2);
            UserModsTab.Controls.Add(button1);
            UserModsTab.Controls.Add(userModsFiles);
            UserModsTab.Location = new Point(4, 24);
            UserModsTab.Name = "UserModsTab";
            UserModsTab.Padding = new Padding(3);
            UserModsTab.Size = new Size(792, 263);
            UserModsTab.TabIndex = 1;
            UserModsTab.Text = "user\\mods";
            UserModsTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(612, 111);
            button3.Name = "button3";
            button3.Size = new Size(172, 23);
            button3.TabIndex = 4;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(612, 227);
            button2.Name = "button2";
            button2.Size = new Size(172, 23);
            button2.TabIndex = 3;
            button2.Text = "Export to active profile";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(612, 140);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 2;
            button1.Text = "Open game files in explorer";
            button1.UseVisualStyleBackColor = true;
            // 
            // userModsFiles
            // 
            userModsFiles.FormattingEnabled = true;
            userModsFiles.ItemHeight = 15;
            userModsFiles.Location = new Point(6, 36);
            userModsFiles.Name = "userModsFiles";
            userModsFiles.Size = new Size(297, 214);
            userModsFiles.TabIndex = 0;
            // 
            // ServerInfoTab
            // 
            ServerInfoTab.Location = new Point(4, 24);
            ServerInfoTab.Name = "ServerInfoTab";
            ServerInfoTab.Size = new Size(792, 263);
            ServerInfoTab.TabIndex = 2;
            ServerInfoTab.Text = "Server Info";
            ServerInfoTab.UseVisualStyleBackColor = true;
            // 
            // LauncherInfoTab
            // 
            LauncherInfoTab.Location = new Point(4, 24);
            LauncherInfoTab.Name = "LauncherInfoTab";
            LauncherInfoTab.Size = new Size(792, 263);
            LauncherInfoTab.TabIndex = 3;
            LauncherInfoTab.Text = "Launcher Info";
            LauncherInfoTab.UseVisualStyleBackColor = true;
            // 
            // ProfilesTab
            // 
            ProfilesTab.Location = new Point(4, 24);
            ProfilesTab.Name = "ProfilesTab";
            ProfilesTab.Size = new Size(792, 263);
            ProfilesTab.TabIndex = 4;
            ProfilesTab.Text = "Profiles";
            ProfilesTab.UseVisualStyleBackColor = true;
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
            ProfileLinkLabel.Size = new Size(40, 15);
            ProfileLinkLabel.TabIndex = 4;
            ProfileLinkLabel.Text = "NONE";
            // 
            // fika_client_status_lbl
            // 
            fika_client_status_lbl.AutoSize = true;
            fika_client_status_lbl.Location = new Point(705, 57);
            fika_client_status_lbl.Name = "fika_client_status_lbl";
            fika_client_status_lbl.Size = new Size(58, 15);
            fika_client_status_lbl.TabIndex = 5;
            fika_client_status_lbl.Text = "Unknown";
            // 
            // fika_server_status_lbl
            // 
            fika_server_status_lbl.AutoSize = true;
            fika_server_status_lbl.Location = new Point(705, 39);
            fika_server_status_lbl.Name = "fika_server_status_lbl";
            fika_server_status_lbl.Size = new Size(58, 15);
            fika_server_status_lbl.TabIndex = 6;
            fika_server_status_lbl.Text = "Unknown";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 57);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "Fika Server Files:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Fika Client Files:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 6;
            label5.Text = "Game Files";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(309, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 214);
            listBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(612, 198);
            button4.Name = "button4";
            button4.Size = new Size(172, 23);
            button4.TabIndex = 8;
            button4.Text = "Import to active profile";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(612, 169);
            button5.Name = "button5";
            button5.Size = new Size(172, 23);
            button5.TabIndex = 9;
            button5.Text = "Open profile files in explorer";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
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
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "playtarky";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ServerModsTab.ResumeLayout(false);
            ServerModsTab.PerformLayout();
            UserModsTab.ResumeLayout(false);
            UserModsTab.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage ServerModsTab;
        private TabPage UserModsTab;
        private TabPage ServerInfoTab;
        private TabPage LauncherInfoTab;
        private Label label1;
        private Label label2;
        private Label ProfileLinkLabel;
        private ListBox bepInExGameFiles;
        private ListBox userModsFiles;
        private Button open_game_bep_btn;
        private Button export_bep_btn;
        private ToolStripMenuItem saveProfileToolStripMenuItem;
        private Button button2;
        private Button button1;
        private TabPage ProfilesTab;
        private Button refresh_bep_btn;
        private Button button3;
        private Label bep_profileFiles_label;
        private Label label3;
        private ListBox bepInExProfileFiles;
        private Button open_profile_bep_btn;
        private Label fika_client_status_lbl;
        private Label fika_server_status_lbl;
        private Label label4;
        private Button import_bep_btn;
        private ListBox listBox1;
        private Label label5;
        private Button button5;
        private Button button4;
    }
}
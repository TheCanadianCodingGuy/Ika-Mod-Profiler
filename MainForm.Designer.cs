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
            menu_file_lbl = new ToolStripMenuItem();
            menu_openprofile_lbl = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            progressBar = new ToolStripProgressBar();
            progressStatusText = new ToolStripStatusLabel();
            spt_version_lbl = new ToolStripStatusLabel();
            fm_tabs_control = new TabControl();
            tab_bep_title = new TabPage();
            bep_tab_info_btn = new Button();
            bep_tab_exportall_btn = new Button();
            bep_tab_importselected_btn = new Button();
            bep_tab_openprofilefile_btn = new Button();
            bep_tab_opengamefile_btn = new Button();
            bep_tab_exportselected_btn = new Button();
            bep_tab_importall_btn = new Button();
            bep_tab_refresh_btn = new Button();
            tab_bep_profilefiles_lbl = new Label();
            tab_bep_gamefiles_lbl = new Label();
            bep_tab_profilefiles_lbox = new ListBox();
            bep_tab_gamefiles_lbox = new ListBox();
            tab_usermod_title = new TabPage();
            user_tab_gamefile_lbl = new Label();
            user_tab_gamefiles_lbox = new ListBox();
            tab_serverinfo_title = new TabPage();
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
            tab_launcherinfo_title = new TabPage();
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
            tab_gameprofile_title = new TabPage();
            profile_tab_gamefile_lbl = new Label();
            profile_tab_gamefiles_lbox = new ListBox();
            serverHttpConfigurationFileBindingSource = new BindingSource(components);
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
            mf_activeprofile_title_lbl = new Label();
            mf_activeprofile_msg_lbl = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            fm_tabs_control.SuspendLayout();
            tab_bep_title.SuspendLayout();
            tab_usermod_title.SuspendLayout();
            tab_serverinfo_title.SuspendLayout();
            tab_launcherinfo_title.SuspendLayout();
            tab_gameprofile_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serverHttpConfigurationFileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_file_lbl });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // menu_file_lbl
            // 
            menu_file_lbl.DropDownItems.AddRange(new ToolStripItem[] { menu_openprofile_lbl });
            menu_file_lbl.Name = "menu_file_lbl";
            resources.ApplyResources(menu_file_lbl, "menu_file_lbl");
            menu_file_lbl.Click += FileToolStripMenuItem_Click;
            // 
            // menu_openprofile_lbl
            // 
            menu_openprofile_lbl.Name = "menu_openprofile_lbl";
            resources.ApplyResources(menu_openprofile_lbl, "menu_openprofile_lbl");
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { progressBar, progressStatusText, spt_version_lbl });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // progressBar
            // 
            progressBar.Margin = new Padding(5, 3, 1, 3);
            progressBar.Name = "progressBar";
            resources.ApplyResources(progressBar, "progressBar");
            // 
            // progressStatusText
            // 
            progressStatusText.Name = "progressStatusText";
            resources.ApplyResources(progressStatusText, "progressStatusText");
            // 
            // spt_version_lbl
            // 
            spt_version_lbl.DisplayStyle = ToolStripItemDisplayStyle.Text;
            spt_version_lbl.Name = "spt_version_lbl";
            resources.ApplyResources(spt_version_lbl, "spt_version_lbl");
            spt_version_lbl.Spring = true;
            // 
            // fm_tabs_control
            // 
            fm_tabs_control.Controls.Add(tab_bep_title);
            fm_tabs_control.Controls.Add(tab_usermod_title);
            fm_tabs_control.Controls.Add(tab_serverinfo_title);
            fm_tabs_control.Controls.Add(tab_launcherinfo_title);
            fm_tabs_control.Controls.Add(tab_gameprofile_title);
            resources.ApplyResources(fm_tabs_control, "fm_tabs_control");
            fm_tabs_control.Name = "fm_tabs_control";
            fm_tabs_control.SelectedIndex = 0;
            // 
            // tab_bep_title
            // 
            tab_bep_title.Controls.Add(bep_tab_info_btn);
            tab_bep_title.Controls.Add(bep_tab_exportall_btn);
            tab_bep_title.Controls.Add(bep_tab_importselected_btn);
            tab_bep_title.Controls.Add(bep_tab_openprofilefile_btn);
            tab_bep_title.Controls.Add(bep_tab_opengamefile_btn);
            tab_bep_title.Controls.Add(bep_tab_exportselected_btn);
            tab_bep_title.Controls.Add(bep_tab_importall_btn);
            tab_bep_title.Controls.Add(bep_tab_refresh_btn);
            tab_bep_title.Controls.Add(tab_bep_profilefiles_lbl);
            tab_bep_title.Controls.Add(tab_bep_gamefiles_lbl);
            tab_bep_title.Controls.Add(bep_tab_profilefiles_lbox);
            tab_bep_title.Controls.Add(bep_tab_gamefiles_lbox);
            resources.ApplyResources(tab_bep_title, "tab_bep_title");
            tab_bep_title.Name = "tab_bep_title";
            tab_bep_title.UseVisualStyleBackColor = true;
            tab_bep_title.MouseEnter += bepInExPluginsTab_MouseEnter;
            // 
            // bep_tab_info_btn
            // 
            bep_tab_info_btn.Cursor = Cursors.Help;
            resources.ApplyResources(bep_tab_info_btn, "bep_tab_info_btn");
            bep_tab_info_btn.Name = "bep_tab_info_btn";
            bep_tab_info_btn_tt.SetToolTip(bep_tab_info_btn, TabContentResource.ListBoxHelper);
            bep_tab_info_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_exportall_btn
            // 
            resources.ApplyResources(bep_tab_exportall_btn, "bep_tab_exportall_btn");
            bep_tab_exportall_btn.Name = "bep_tab_exportall_btn";
            bep_tab_exportall_btn_tt.SetToolTip(bep_tab_exportall_btn, TabContentResource.ExportAll);
            bep_tab_exportall_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_importselected_btn
            // 
            resources.ApplyResources(bep_tab_importselected_btn, "bep_tab_importselected_btn");
            bep_tab_importselected_btn.Name = "bep_tab_importselected_btn";
            bep_tab_importselected_btn_tt.SetToolTip(bep_tab_importselected_btn, TabContentResource.ImportSelected);
            bep_tab_importselected_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_openprofilefile_btn
            // 
            resources.ApplyResources(bep_tab_openprofilefile_btn, "bep_tab_openprofilefile_btn");
            bep_tab_openprofilefile_btn.Name = "bep_tab_openprofilefile_btn";
            bep_tab_openprofilefile_btn_tt.SetToolTip(bep_tab_openprofilefile_btn, TabContentResource.OpenFileExplorer);
            bep_tab_openprofilefile_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_opengamefile_btn
            // 
            resources.ApplyResources(bep_tab_opengamefile_btn, "bep_tab_opengamefile_btn");
            bep_tab_opengamefile_btn.Name = "bep_tab_opengamefile_btn";
            bep_tab_opengamefile_btn_tt.SetToolTip(bep_tab_opengamefile_btn, TabContentResource.OpenFileExplorer);
            bep_tab_opengamefile_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_exportselected_btn
            // 
            resources.ApplyResources(bep_tab_exportselected_btn, "bep_tab_exportselected_btn");
            bep_tab_exportselected_btn.Name = "bep_tab_exportselected_btn";
            bep_tab_exportselected_btn_tt.SetToolTip(bep_tab_exportselected_btn, TabContentResource.ExportSelected);
            bep_tab_exportselected_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_importall_btn
            // 
            resources.ApplyResources(bep_tab_importall_btn, "bep_tab_importall_btn");
            bep_tab_importall_btn.Name = "bep_tab_importall_btn";
            bep_tab_importall_btn_tt.SetToolTip(bep_tab_importall_btn, TabContentResource.ImportAll);
            bep_tab_importall_btn.UseVisualStyleBackColor = true;
            // 
            // bep_tab_refresh_btn
            // 
            resources.ApplyResources(bep_tab_refresh_btn, "bep_tab_refresh_btn");
            bep_tab_refresh_btn.Name = "bep_tab_refresh_btn";
            bep_tab_refresh_btn_tt.SetToolTip(bep_tab_refresh_btn, TabContentResource.Refresh);
            bep_tab_refresh_btn.UseVisualStyleBackColor = true;
            // 
            // tab_bep_profilefiles_lbl
            // 
            resources.ApplyResources(tab_bep_profilefiles_lbl, "tab_bep_profilefiles_lbl");
            tab_bep_profilefiles_lbl.Name = "tab_bep_profilefiles_lbl";
            // 
            // tab_bep_gamefiles_lbl
            // 
            resources.ApplyResources(tab_bep_gamefiles_lbl, "tab_bep_gamefiles_lbl");
            tab_bep_gamefiles_lbl.Name = "tab_bep_gamefiles_lbl";
            // 
            // bep_tab_profilefiles_lbox
            // 
            bep_tab_profilefiles_lbox.FormattingEnabled = true;
            resources.ApplyResources(bep_tab_profilefiles_lbox, "bep_tab_profilefiles_lbox");
            bep_tab_profilefiles_lbox.Name = "bep_tab_profilefiles_lbox";
            bep_tab_profilefiles_lbox.SelectionMode = SelectionMode.None;
            bep_tab_profilefiles_lbox.MouseEnter += bep_tab_profilefiles_lbox_MouseEnter;
            // 
            // bep_tab_gamefiles_lbox
            // 
            bep_tab_gamefiles_lbox.FormattingEnabled = true;
            resources.ApplyResources(bep_tab_gamefiles_lbox, "bep_tab_gamefiles_lbox");
            bep_tab_gamefiles_lbox.Name = "bep_tab_gamefiles_lbox";
            bep_tab_gamefiles_lbox.SelectionMode = SelectionMode.None;
            bep_tab_gamefiles_lbox.MouseEnter += bep_tab_gamefiles_lbox_MouseEnter;
            // 
            // tab_usermod_title
            // 
            tab_usermod_title.Controls.Add(user_tab_gamefile_lbl);
            tab_usermod_title.Controls.Add(user_tab_gamefiles_lbox);
            resources.ApplyResources(tab_usermod_title, "tab_usermod_title");
            tab_usermod_title.Name = "tab_usermod_title";
            tab_usermod_title.UseVisualStyleBackColor = true;
            // 
            // user_tab_gamefile_lbl
            // 
            resources.ApplyResources(user_tab_gamefile_lbl, "user_tab_gamefile_lbl");
            user_tab_gamefile_lbl.Name = "user_tab_gamefile_lbl";
            // 
            // user_tab_gamefiles_lbox
            // 
            user_tab_gamefiles_lbox.FormattingEnabled = true;
            resources.ApplyResources(user_tab_gamefiles_lbox, "user_tab_gamefiles_lbox");
            user_tab_gamefiles_lbox.Name = "user_tab_gamefiles_lbox";
            // 
            // tab_serverinfo_title
            // 
            tab_serverinfo_title.Controls.Add(SI_logreq_chk);
            tab_serverinfo_title.Controls.Add(SI_logreq_lbl);
            tab_serverinfo_title.Controls.Add(SI_wsdelay_txt);
            tab_serverinfo_title.Controls.Add(SI_wsdelay_lbl);
            tab_serverinfo_title.Controls.Add(SI_beport_txt);
            tab_serverinfo_title.Controls.Add(SI_beport_lbl);
            tab_serverinfo_title.Controls.Add(SI_beip_txt);
            tab_serverinfo_title.Controls.Add(SI_beip_lbl);
            tab_serverinfo_title.Controls.Add(SI_port_txt);
            tab_serverinfo_title.Controls.Add(SI_port_lbl);
            tab_serverinfo_title.Controls.Add(SI_ip_txt);
            tab_serverinfo_title.Controls.Add(SI_ip_lbl);
            resources.ApplyResources(tab_serverinfo_title, "tab_serverinfo_title");
            tab_serverinfo_title.Name = "tab_serverinfo_title";
            tab_serverinfo_title.UseVisualStyleBackColor = true;
            // 
            // SI_logreq_chk
            // 
            resources.ApplyResources(SI_logreq_chk, "SI_logreq_chk");
            SI_logreq_chk.Name = "SI_logreq_chk";
            SI_logreq_chk.UseVisualStyleBackColor = true;
            // 
            // SI_logreq_lbl
            // 
            resources.ApplyResources(SI_logreq_lbl, "SI_logreq_lbl");
            SI_logreq_lbl.Name = "SI_logreq_lbl";
            SI_logreq_lbl.Click += SI_logreq_lbl_Click;
            // 
            // SI_wsdelay_txt
            // 
            resources.ApplyResources(SI_wsdelay_txt, "SI_wsdelay_txt");
            SI_wsdelay_txt.Name = "SI_wsdelay_txt";
            // 
            // SI_wsdelay_lbl
            // 
            resources.ApplyResources(SI_wsdelay_lbl, "SI_wsdelay_lbl");
            SI_wsdelay_lbl.Name = "SI_wsdelay_lbl";
            SI_wsdelay_lbl.Click += SI_wsdelay_lbl_Click;
            // 
            // SI_beport_txt
            // 
            resources.ApplyResources(SI_beport_txt, "SI_beport_txt");
            SI_beport_txt.Name = "SI_beport_txt";
            // 
            // SI_beport_lbl
            // 
            resources.ApplyResources(SI_beport_lbl, "SI_beport_lbl");
            SI_beport_lbl.Name = "SI_beport_lbl";
            SI_beport_lbl.Click += SI_beport_lbl_Click;
            // 
            // SI_beip_txt
            // 
            resources.ApplyResources(SI_beip_txt, "SI_beip_txt");
            SI_beip_txt.Name = "SI_beip_txt";
            // 
            // SI_beip_lbl
            // 
            resources.ApplyResources(SI_beip_lbl, "SI_beip_lbl");
            SI_beip_lbl.Name = "SI_beip_lbl";
            SI_beip_lbl.Click += SI_beip_lbl_Click;
            // 
            // SI_port_txt
            // 
            resources.ApplyResources(SI_port_txt, "SI_port_txt");
            SI_port_txt.Name = "SI_port_txt";
            // 
            // SI_port_lbl
            // 
            resources.ApplyResources(SI_port_lbl, "SI_port_lbl");
            SI_port_lbl.Name = "SI_port_lbl";
            SI_port_lbl.Click += SI_port_lbl_Click;
            // 
            // SI_ip_txt
            // 
            resources.ApplyResources(SI_ip_txt, "SI_ip_txt");
            SI_ip_txt.Name = "SI_ip_txt";
            // 
            // SI_ip_lbl
            // 
            resources.ApplyResources(SI_ip_lbl, "SI_ip_lbl");
            SI_ip_lbl.Name = "SI_ip_lbl";
            SI_ip_lbl.Click += SI_ip_lbl_Click;
            // 
            // tab_launcherinfo_title
            // 
            tab_launcherinfo_title.Controls.Add(LI_defaultlocale_txt);
            tab_launcherinfo_title.Controls.Add(LI_defaultlocale_lbl);
            tab_launcherinfo_title.Controls.Add(LI_serverurl_txt);
            tab_launcherinfo_title.Controls.Add(LI_filepath_txt);
            tab_launcherinfo_title.Controls.Add(LI_servername_txt);
            tab_launcherinfo_title.Controls.Add(LI_firstrun_chk);
            tab_launcherinfo_title.Controls.Add(LI_filepath_lbl);
            tab_launcherinfo_title.Controls.Add(LI_serverurl_lbl);
            tab_launcherinfo_title.Controls.Add(LI_servername_lbl);
            tab_launcherinfo_title.Controls.Add(LI_firstrun_lbl);
            tab_launcherinfo_title.Controls.Add(LI_useAutoLogin_chk);
            tab_launcherinfo_title.Controls.Add(LI_password_txt);
            tab_launcherinfo_title.Controls.Add(LI_password_lbl);
            tab_launcherinfo_title.Controls.Add(LI_username_txt);
            tab_launcherinfo_title.Controls.Add(LI_username_lbl);
            tab_launcherinfo_title.Controls.Add(LI_useAutoLogin_lbl);
            resources.ApplyResources(tab_launcherinfo_title, "tab_launcherinfo_title");
            tab_launcherinfo_title.Name = "tab_launcherinfo_title";
            tab_launcherinfo_title.UseVisualStyleBackColor = true;
            // 
            // LI_defaultlocale_txt
            // 
            resources.ApplyResources(LI_defaultlocale_txt, "LI_defaultlocale_txt");
            LI_defaultlocale_txt.Name = "LI_defaultlocale_txt";
            // 
            // LI_defaultlocale_lbl
            // 
            resources.ApplyResources(LI_defaultlocale_lbl, "LI_defaultlocale_lbl");
            LI_defaultlocale_lbl.Name = "LI_defaultlocale_lbl";
            LI_defaultlocale_lbl.Click += LI_defaultlocale_lbl_Click;
            // 
            // LI_serverurl_txt
            // 
            resources.ApplyResources(LI_serverurl_txt, "LI_serverurl_txt");
            LI_serverurl_txt.Name = "LI_serverurl_txt";
            // 
            // LI_filepath_txt
            // 
            resources.ApplyResources(LI_filepath_txt, "LI_filepath_txt");
            LI_filepath_txt.Name = "LI_filepath_txt";
            // 
            // LI_servername_txt
            // 
            resources.ApplyResources(LI_servername_txt, "LI_servername_txt");
            LI_servername_txt.Name = "LI_servername_txt";
            // 
            // LI_firstrun_chk
            // 
            resources.ApplyResources(LI_firstrun_chk, "LI_firstrun_chk");
            LI_firstrun_chk.Name = "LI_firstrun_chk";
            LI_firstrun_chk.UseVisualStyleBackColor = true;
            // 
            // LI_filepath_lbl
            // 
            resources.ApplyResources(LI_filepath_lbl, "LI_filepath_lbl");
            LI_filepath_lbl.Name = "LI_filepath_lbl";
            LI_filepath_lbl.Click += LI_filepath_lbl_Click;
            // 
            // LI_serverurl_lbl
            // 
            resources.ApplyResources(LI_serverurl_lbl, "LI_serverurl_lbl");
            LI_serverurl_lbl.Name = "LI_serverurl_lbl";
            LI_serverurl_lbl.Click += LI_serverurl_lbl_Click;
            // 
            // LI_servername_lbl
            // 
            resources.ApplyResources(LI_servername_lbl, "LI_servername_lbl");
            LI_servername_lbl.Name = "LI_servername_lbl";
            LI_servername_lbl.Click += LI_servername_lbl_Click;
            // 
            // LI_firstrun_lbl
            // 
            resources.ApplyResources(LI_firstrun_lbl, "LI_firstrun_lbl");
            LI_firstrun_lbl.Name = "LI_firstrun_lbl";
            LI_firstrun_lbl.Click += LI_firstrun_lbl_Click;
            // 
            // LI_useAutoLogin_chk
            // 
            resources.ApplyResources(LI_useAutoLogin_chk, "LI_useAutoLogin_chk");
            LI_useAutoLogin_chk.Name = "LI_useAutoLogin_chk";
            LI_useAutoLogin_chk.UseVisualStyleBackColor = true;
            // 
            // LI_password_txt
            // 
            resources.ApplyResources(LI_password_txt, "LI_password_txt");
            LI_password_txt.Name = "LI_password_txt";
            // 
            // LI_password_lbl
            // 
            resources.ApplyResources(LI_password_lbl, "LI_password_lbl");
            LI_password_lbl.Name = "LI_password_lbl";
            LI_password_lbl.Click += LI_password_lbl_Click;
            // 
            // LI_username_txt
            // 
            resources.ApplyResources(LI_username_txt, "LI_username_txt");
            LI_username_txt.Name = "LI_username_txt";
            // 
            // LI_username_lbl
            // 
            resources.ApplyResources(LI_username_lbl, "LI_username_lbl");
            LI_username_lbl.Name = "LI_username_lbl";
            LI_username_lbl.Click += LI_username_lbl_Click;
            // 
            // LI_useAutoLogin_lbl
            // 
            resources.ApplyResources(LI_useAutoLogin_lbl, "LI_useAutoLogin_lbl");
            LI_useAutoLogin_lbl.Name = "LI_useAutoLogin_lbl";
            LI_useAutoLogin_lbl.Click += LI_useAutoLogin_lbl_Click;
            // 
            // tab_gameprofile_title
            // 
            tab_gameprofile_title.Controls.Add(profile_tab_gamefile_lbl);
            tab_gameprofile_title.Controls.Add(profile_tab_gamefiles_lbox);
            resources.ApplyResources(tab_gameprofile_title, "tab_gameprofile_title");
            tab_gameprofile_title.Name = "tab_gameprofile_title";
            tab_gameprofile_title.UseVisualStyleBackColor = true;
            // 
            // profile_tab_gamefile_lbl
            // 
            resources.ApplyResources(profile_tab_gamefile_lbl, "profile_tab_gamefile_lbl");
            profile_tab_gamefile_lbl.Name = "profile_tab_gamefile_lbl";
            // 
            // profile_tab_gamefiles_lbox
            // 
            profile_tab_gamefiles_lbox.FormattingEnabled = true;
            resources.ApplyResources(profile_tab_gamefiles_lbox, "profile_tab_gamefiles_lbox");
            profile_tab_gamefiles_lbox.Name = "profile_tab_gamefiles_lbox";
            // 
            // serverHttpConfigurationFileBindingSource
            // 
            serverHttpConfigurationFileBindingSource.DataSource = typeof(Models.ServerHttpConfigurationFile);
            // 
            // fika_client_status_lbl
            // 
            resources.ApplyResources(fika_client_status_lbl, "fika_client_status_lbl");
            fika_client_status_lbl.Name = "fika_client_status_lbl";
            // 
            // fika_server_status_lbl
            // 
            resources.ApplyResources(fika_server_status_lbl, "fika_server_status_lbl");
            fika_server_status_lbl.Name = "fika_server_status_lbl";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
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
            // mf_activeprofile_title_lbl
            // 
            resources.ApplyResources(mf_activeprofile_title_lbl, "mf_activeprofile_title_lbl");
            mf_activeprofile_title_lbl.Name = "mf_activeprofile_title_lbl";
            // 
            // mf_activeprofile_msg_lbl
            // 
            resources.ApplyResources(mf_activeprofile_msg_lbl, "mf_activeprofile_msg_lbl");
            mf_activeprofile_msg_lbl.Name = "mf_activeprofile_msg_lbl";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mf_activeprofile_msg_lbl);
            Controls.Add(mf_activeprofile_title_lbl);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(fika_server_status_lbl);
            Controls.Add(fika_client_status_lbl);
            Controls.Add(fm_tabs_control);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            fm_tabs_control.ResumeLayout(false);
            tab_bep_title.ResumeLayout(false);
            tab_bep_title.PerformLayout();
            tab_usermod_title.ResumeLayout(false);
            tab_usermod_title.PerformLayout();
            tab_serverinfo_title.ResumeLayout(false);
            tab_serverinfo_title.PerformLayout();
            tab_launcherinfo_title.ResumeLayout(false);
            tab_launcherinfo_title.PerformLayout();
            tab_gameprofile_title.ResumeLayout(false);
            tab_gameprofile_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serverHttpConfigurationFileBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_file_lbl;
        private ToolStripMenuItem menu_openprofile_lbl;
        private StatusStrip statusStrip1;
        public ToolStripProgressBar progressBar;
        public ToolStripStatusLabel progressStatusText;
        private TabControl fm_tabs_control;
        private TabPage tab_bep_title;
        private TabPage tab_usermod_title;
        private TabPage tab_serverinfo_title;
        private TabPage tab_launcherinfo_title;
        private Label label2;
        private ListBox bep_tab_gamefiles_lbox;
        private ListBox user_tab_gamefiles_lbox;
        private TabPage tab_gameprofile_title;
        private Label tab_bep_profilefiles_lbl;
        private Label tab_bep_gamefiles_lbl;
        private ListBox bep_tab_profilefiles_lbox;
        private Label fika_client_status_lbl;
        private Label fika_server_status_lbl;
        private Label label4;
        private Label user_tab_gamefile_lbl;
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
        private Label profile_tab_gamefile_lbl;
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
        private Label mf_activeprofile_title_lbl;
        private Label mf_activeprofile_msg_lbl;
    }
}
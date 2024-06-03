using playtarky.Resources.Forms.CreateProfileForm;
using playtarky.Resources.Forms.MainForm.TabContent;

namespace playtarky
{
    partial class CreateProfileForm
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
        public static string ProfileName;
        public static bool UsesFika;
        public static bool IsFikaHost;
        public static bool IsOverwriteProfile;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfileForm));
            label1 = new Label();
            CP_ProfileName_txt = new TextBox();
            CP_UsesFika_chk = new CheckBox();
            CP_IsFikaHost_chk = new CheckBox();
            CP_Create_btn = new Button();
            CP_Cancel_btn = new Button();
            groupBox1 = new GroupBox();
            CP_fika_help_btn = new Button();
            CP_fika_help_btn_tt = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // CP_ProfileName_txt
            // 
            resources.ApplyResources(CP_ProfileName_txt, "CP_ProfileName_txt");
            CP_ProfileName_txt.Name = "CP_ProfileName_txt";
            // 
            // CP_UsesFika_chk
            // 
            resources.ApplyResources(CP_UsesFika_chk, "CP_UsesFika_chk");
            CP_UsesFika_chk.Name = "CP_UsesFika_chk";
            CP_UsesFika_chk.Text = CreateProfileFormResource.UsesFika;
            CP_UsesFika_chk.UseVisualStyleBackColor = true;
            CP_UsesFika_chk.CheckedChanged += CP_UsesFika_chk_CheckedChanged;
            // 
            // CP_IsFikaHost_chk
            // 
            resources.ApplyResources(CP_IsFikaHost_chk, "CP_IsFikaHost_chk");
            CP_IsFikaHost_chk.Name = "CP_IsFikaHost_chk";
            CP_IsFikaHost_chk.Text = CreateProfileFormResource.IsFikaHost;
            CP_IsFikaHost_chk.UseVisualStyleBackColor = true;
            // 
            // CP_Create_btn
            // 
            resources.ApplyResources(CP_Create_btn, "CP_Create_btn");
            CP_Create_btn.Name = "CP_Create_btn";
            CP_Create_btn.Text = CreateProfileFormResource.Create;
            CP_Create_btn.UseVisualStyleBackColor = true;
            CP_Create_btn.Click += CP_Create_btn_Click;
            // 
            // CP_Cancel_btn
            // 
            resources.ApplyResources(CP_Cancel_btn, "CP_Cancel_btn");
            CP_Cancel_btn.Name = "CP_Cancel_btn";
            CP_Cancel_btn.Text = CreateProfileFormResource.Cancel;
            CP_Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CP_fika_help_btn);
            groupBox1.Controls.Add(CP_UsesFika_chk);
            groupBox1.Controls.Add(CP_IsFikaHost_chk);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // CP_fika_help_btn
            // 
            CP_fika_help_btn.Cursor = Cursors.Help;
            resources.ApplyResources(CP_fika_help_btn, "CP_fika_help_btn");
            CP_fika_help_btn.Name = "CP_fika_help_btn";
            CP_fika_help_btn_tt.SetToolTip(CP_fika_help_btn, CreateProfileFormResource.FikaHelp);
            CP_fika_help_btn.UseVisualStyleBackColor = true;
            // 
            // CP_fika_help_btn_tt
            // 
            CP_fika_help_btn_tt.AutoPopDelay = 5000;
            CP_fika_help_btn_tt.InitialDelay = 100;
            CP_fika_help_btn_tt.ReshowDelay = 100;
            // 
            // CreateProfileForm
            // 
            AcceptButton = CP_Create_btn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CP_Cancel_btn;
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(CP_Cancel_btn);
            Controls.Add(CP_Create_btn);
            Controls.Add(CP_ProfileName_txt);
            Controls.Add(label1);
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateProfileForm";
            ShowIcon = false;
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox CP_ProfileName_txt;
        private CheckBox CP_UsesFika_chk;
        private CheckBox CP_IsFikaHost_chk;
        private Button CP_Create_btn;
        private Button CP_Cancel_btn;
        private GroupBox groupBox1;
        private Button CP_fika_help_btn;
        private ToolTip CP_fika_help_btn_tt;
    }
}
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
        public string ProfileName
        {
            get { return "test"; }// textBoxUsername.Text; }
        }

        public bool UsesFika
        {
            get { return true; }// checkBoxOnlineOnly.Checked; }
        }

        public bool WillHostFika
        {
            get { return true; }// checkBoxOnlineOnly.Checked; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfileForm));
            label1 = new Label();
            CP_ProfileName_txt = new TextBox();
            CP_UsesFika_chk = new CheckBox();
            CP_IsFikaHost_chk = new CheckBox();
            CP_Create_btn = new Button();
            CP_Cancel_btn = new Button();
            groupBox1 = new GroupBox();
            CP_fika_help_btn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Profile Name";
            // 
            // CP_ProfileName_txt
            // 
            CP_ProfileName_txt.Location = new Point(12, 27);
            CP_ProfileName_txt.Name = "CP_ProfileName_txt";
            CP_ProfileName_txt.Size = new Size(319, 23);
            CP_ProfileName_txt.TabIndex = 2;
            // 
            // CP_UsesFika_chk
            // 
            CP_UsesFika_chk.AutoSize = true;
            CP_UsesFika_chk.Location = new Point(17, 22);
            CP_UsesFika_chk.Name = "CP_UsesFika_chk";
            CP_UsesFika_chk.Size = new Size(135, 19);
            CP_UsesFika_chk.TabIndex = 3;
            CP_UsesFika_chk.Text = CreateProfileFormResource.UsesFika;
            CP_UsesFika_chk.UseVisualStyleBackColor = true;
            // 
            // CP_IsFikaHost_chk
            // 
            CP_IsFikaHost_chk.AutoSize = true;
            CP_IsFikaHost_chk.Location = new Point(17, 47);
            CP_IsFikaHost_chk.Name = "CP_IsFikaHost_chk";
            CP_IsFikaHost_chk.Size = new Size(156, 19);
            CP_IsFikaHost_chk.TabIndex = 4;
            CP_IsFikaHost_chk.Text = CreateProfileFormResource.IsFikaHost;
            CP_IsFikaHost_chk.UseVisualStyleBackColor = true;
            // 
            // CP_Create_btn
            // 
            CP_Create_btn.Location = new Point(175, 137);
            CP_Create_btn.Name = "CP_Create_btn";
            CP_Create_btn.Size = new Size(75, 23);
            CP_Create_btn.TabIndex = 5;
            CP_Create_btn.Text = CreateProfileFormResource.Create;
            CP_Create_btn.UseVisualStyleBackColor = true;
            CP_Create_btn.Click += CP_Create_btn_Click;
            // 
            // CP_Cancel_btn
            // 
            CP_Cancel_btn.Location = new Point(256, 137);
            CP_Cancel_btn.Name = "CP_Cancel_btn";
            CP_Cancel_btn.Size = new Size(75, 23);
            CP_Cancel_btn.TabIndex = 6;
            CP_Cancel_btn.Text = CreateProfileFormResource.Cancel;
            CP_Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CP_fika_help_btn);
            groupBox1.Controls.Add(CP_UsesFika_chk);
            groupBox1.Controls.Add(CP_IsFikaHost_chk);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 75);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fika Compatibility";
            // 
            // CP_fika_help_btn
            // 
            CP_fika_help_btn.Cursor = Cursors.Help;
            CP_fika_help_btn.Image = (Image)resources.GetObject("CP_fika_help_btn.Image");
            CP_fika_help_btn.Location = new Point(283, 15);
            CP_fika_help_btn.Name = "CP_fika_help_btn";
            CP_fika_help_btn.Size = new Size(30, 30);
            CP_fika_help_btn.TabIndex = 5;
            CP_fika_help_btn.UseVisualStyleBackColor = true;
            ToolTip CP_fika_help_btn_tt = new ToolTip();
            CP_fika_help_btn_tt.AutoPopDelay = 5000;
            CP_fika_help_btn_tt.InitialDelay = 100;
            CP_fika_help_btn_tt.ShowAlways = false;
            CP_fika_help_btn_tt.SetToolTip(CP_fika_help_btn, CreateProfileFormResource.FikaHelp);
            // 
            // CreateProfileForm
            // 
            AcceptButton = CP_Create_btn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CP_Cancel_btn;
            ClientSize = new Size(337, 168);
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
            Text = "Create New Profile";
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
    }
}
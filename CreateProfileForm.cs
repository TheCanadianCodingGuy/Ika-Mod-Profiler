using playtarky.Resources.Forms.CreateProfileForm;
using System.Text.RegularExpressions;

namespace playtarky
{
    public partial class CreateProfileForm : Form
    {
        public Regex regex = new Regex(@"^[a-zA-Z0-9_-]{3,32}$");
        public bool OverwriteExistingProfile = false;

        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void CP_Create_btn_Click(object sender, EventArgs e)
        {
            if (Validation(CP_ProfileName_txt.Text))
            {
                //Return Data
                ProfileName = CP_ProfileName_txt.Text.Trim();
                UsesFika = CP_UsesFika_chk.Checked;
                IsFikaHost = CP_IsFikaHost_chk.Checked;
                IsOverwriteProfile = OverwriteExistingProfile;

                // Set the DialogResult to OK before closing the form
                this.DialogResult = DialogResult.OK;
                // Close the form
                this.Close();
            }
        }

        private bool Validation(string inputVal)
        {
            var isValid = false;
            inputVal = inputVal.Trim();
            if (regex.IsMatch(inputVal))
            {
                string filePath = Path.Combine(MainForm.APP_PROFILES_DIR, inputVal) + ".zip";

                if (File.Exists(filePath))
                {

                    DialogResult result = MessageBox.Show(string.Format(CreateProfileFormResource.ProfileAlreadyExists, inputVal), CreateProfileFormResource.ProfileAlreadyExistsTitle, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        OverwriteExistingProfile = true;
                        isValid = true;
                    }
                }
                else
                {
                    isValid = true;
                }
            }
            else
            {
                MessageBox.Show(CreateProfileFormResource.ValidationFailedMsg);
            }
            return isValid;
        }

        private void CP_UsesFika_chk_CheckedChanged(object sender, EventArgs e)
        {
            CP_IsFikaHost_chk.Enabled = CP_UsesFika_chk.Checked;
            CP_IsFikaHost_chk.Checked = false;
        }
    }
}

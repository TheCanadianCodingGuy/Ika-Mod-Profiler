using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playtarky
{
    public partial class CreateProfileForm : Form
    {
        //public const string GAME_DIR = @"C:\SPT\";
        //public const string APP_PROFILES_DIR_PARTIAL = "ikaprofiler";
        //public const string APP_PROFILES_DIR = $"{GAME_DIR}{APP_PROFILES_DIR_PARTIAL}";
        public Regex regex = new Regex(@"^[a-zA-Z0-9_-]{3,32}$");

        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void CP_Create_btn_Click(object sender, EventArgs e)
        {
            if (Validation(CP_ProfileName_txt.Text))
            {
                // Set the DialogResult to OK before closing the form
                this.DialogResult = DialogResult.OK;

                // Close the form
                this.Close();
            }
        }

        private bool Validation(string inputVal)
        {
            if (regex.IsMatch(inputVal))
            {
                string folderPath = Path.Combine("APP_PROFILES_DIR", inputVal);

                if (Directory.Exists(folderPath))
                {
                    Console.WriteLine("Folder already exists in APP_PROFILES_DIR.");
                }
                else
                {
                    Console.WriteLine("Validation successful. Folder does not exist in APP_PROFILES_DIR.");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Validation failed. The input value should contain 4 to 32 characters comprising letters, numbers, underscores, and hyphens only, starting with a letter or number only.");
            }
            return false;
        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DCSLibraryRepository
{
    public partial class LoginForm : MaterialForm
    {
        private string path = @"C:\ProgramData\DCSlogs";
        private string logfile = "data";
        private string logged = "current_user";

        public LoginForm()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(logfile))
            {
                File.Create(logfile);
            }
            if (!File.Exists(logged))
            {
                File.Create(logged);
            }

            this.MaximizeBox = false;
            
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckbox.Checked == true)
            {
                PasswordField.UseSystemPasswordChar = false;
                PasswordField.PasswordChar = default;
            }
            else
            {
                PasswordField.UseSystemPasswordChar = true;
            }
           
        }
        private void LoginPressed(object sender, EventArgs e)
        {
            ValidateCredentials(UsernameField.Text, PasswordField.Text);
            UsernameField.Clear();
            PasswordField.Clear();
            ShowPasswordCheckbox.Checked = false;
        }

        private bool ValidateCredentials(string username, string password)
        {
            string[] accounts = File.ReadAllLines(Path.Combine(path, logfile));
            foreach (string account in accounts)
            {
                if (UsernameField.Text == "admin" && PasswordField.Text == "admin")
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    break;
                }
                string[] credentials = account.Split(',');
                if (credentials[5] == username && credentials[6] == password)
                {
                    //The current user
                    InvalidLabel.Visible = false;

                    File.WriteAllText(Path.Combine(path, logged), credentials[5]);

                    MainForm main = new MainForm();
                    main.Show();

                    return true;
                }
            }
            InvalidLabel.Visible = true;
            return false;
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();

        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                materialLabel1.Text = "orb";
            }
        }

    }
}
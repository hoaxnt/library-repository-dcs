using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace DCSLibraryRepository
{
    public partial class RegisterForm : MaterialForm
    {
        private string path = @"C:\ProgramData\DCSlogs";
        private string logfile = "data";

        public RegisterForm()
        {

            InitializeComponent();
            RegistrationSuccessLabel.Visible = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameField.Text;
            string lastName = LastNameField.Text;
            string email = EmailField.Text;
            string studentNumber = StudentNumberField.Text;
            string course = YearCourseCombo.Text;
            string username = UsernameField.Text;
            string password = PasswordField.Text;

            // Concatenate the user information with a separator
            string userInfo = $"{firstName},{lastName},{email},{studentNumber},{course},{username},{password}";

            // Append the new user information to the accounts file
            File.AppendAllText(Path.Combine(path, logfile), userInfo + Environment.NewLine);

            RegistrationSuccessLabel.Visible = true;
            ClearInformation(true);

            
        }

        private void ClearInformation(bool clear)
        {
            if (clear)
            {
                FirstNameField.Clear();
                LastNameField.Clear();
                EmailField.Clear();
                StudentNumberField.Clear();
                YearCourseCombo.Text = "None";
                UsernameField.Clear();
                PasswordField.Clear();
            }
        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DCSLibraryRepository
{
    public partial class MainForm : MaterialForm
    {
        private string path = @"C:\ProgramData\DCSlogs";
        private string logfile = "data";
        private string logged = "current_user";
        
        public MainForm()
        {
            this.MaximizeBox = false;

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);

            //Startup
            string[] accounts = File.ReadAllLines(Path.Combine(path, logfile));
            string[] current_user = File.ReadAllLines(Path.Combine(path, logged));
            foreach (string account in accounts)
            {
                string[] credentials = account.Split(',');
                if (credentials[5] == current_user[0])
                {
                    //Check the current user
                    DetailsLabel.Text = 
                        $"First Name: {credentials[0] + Environment.NewLine}" +
                        $"Last Name: {credentials[1] + Environment.NewLine}" +
                        $"Email: {credentials[2] + Environment.NewLine}" +
                        $"Student Number: {credentials[3] + Environment.NewLine}" +
                        $"Year/Course: {credentials[4] + Environment.NewLine}" +
                        $"Username: {credentials[5] + Environment.NewLine}" +
                        $"Password: {credentials[6] + Environment.NewLine}";
                }
                         
            }
            
        
        }

    }
}

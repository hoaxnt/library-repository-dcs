using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace DCSLibraryRepository
{
    public partial class AdminPanel : MaterialForm
    {
        private string path = @"C:\ProgramData\DCSlogs";
        private string logfile = "data";
        private string logged = "current_user";

        public AdminPanel()
        {
            this.MaximizeBox = false;

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);

            string[] accounts = File.ReadAllLines(Path.Combine(path, logfile));
            foreach (string account in accounts)
            {
                UserListPanel.AddItem(account);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        { 
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
        }
       
    }
}

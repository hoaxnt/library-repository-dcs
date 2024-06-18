using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace DCSLibraryRepository
{
    public partial class AdminPanel : MaterialForm
    {
        public AdminPanel()
        {
            this.MaximizeBox = false;

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);
        }
    }
}

using _24_04_03_Actividad_1.Models;
using _24_04_03_Actividad_1.Services;
using _24_04_03_Actividad_1.Views;
namespace _24_04_03_Actividad_1
{
    public partial class MainForm : Form
    {
        private User? _CurrentUser;
        private UserService _UserService = UserService.GetInstance();
        public MainForm(User currentUser)
        {
            InitializeComponent();
            this._CurrentUser = currentUser;

            this.LoadUsername();
            this.LoadProfilePic();
        }

        private void LoadUsername()
        {
            NameLbl.Text = this._CurrentUser.Name;
        }

        private void LoadProfilePic()
        {
            string appPath = Application.StartupPath;
            try
            {
                ProfilePic.Image = Image.FromFile(Path.Combine(appPath, "Uploads", this._CurrentUser.ProfilePic));
            }
            catch (FileNotFoundException)
            {
                ProfilePic.Image = Image.FromFile(Path.Combine(appPath, "Uploads/default.jpg"));
            }
        }

        private void UploadPicBtn_Click(object sender, EventArgs e)
        {
            if (ProfilePicLoader.ShowDialog() == DialogResult.OK)
            {
                Image picImage = Image.FromFile(ProfilePicLoader.FileName);

                // Guardar la imagen en una carpeta dentro de la aplicación
                string fileName = Path.GetFileName(ProfilePicLoader.FileName);
                string filePath = Path.Combine(Application.StartupPath, "Uploads", fileName);
                picImage.Save(filePath);

                ProfilePic.Image = Image.FromFile(ProfilePicLoader.FileName);
                _UserService.UpdateUserPic(this._CurrentUser.Username, fileName);
            }
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form calculator = new CalculatorForm(this._CurrentUser);
            calculator.ShowDialog();
        }

        private void concatenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form concatenator = new ConcatForm(this._CurrentUser);
            concatenator.ShowDialog();
        }
    }
}

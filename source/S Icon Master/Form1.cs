namespace S_Icon_Master
{
    public partial class SelectDirForm : Form
    {
        bool validDir = false;
        public SelectDirForm()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a parent directory";
                fbd.ShowNewFolderButton = false;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    ParentDirText.Text = fbd.SelectedPath;
                    validDir = true;
                }
                else
                {
                    ParentDirText.Text = "Error: No directory selected or directory is invalid.";
                    validDir = false;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (validDir)
            {
                MainForm mainForm = new MainForm(ParentDirText.Text);
                mainForm.Show();
                Hide();
            }
        }
    }
}
namespace CopyBackup
{
    public partial class FormGetName : Form
    {
        public string ItemName { get; set; } = string.Empty;

        public FormGetName()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ItemName = TextBoxName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}

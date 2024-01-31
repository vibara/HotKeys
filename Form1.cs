namespace HotKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && 
                e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                // Your hotkey action here
                MessageBox.Show($"Alt/Ctrl/Shift + {e.KeyCode} pressed. Processing will be stopped (it wont't catch the next press)");
                this.KeyDown -= MainForm_KeyDown;
            }
        }
    }
}
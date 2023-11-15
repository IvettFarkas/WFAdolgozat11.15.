namespace WFAdolgozat11._15_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pirosLabel.Click += SzinLabelClick;
            zoldLabel.Click += SzinLabelClick;
            kekLabel.Click += SzinLabelClick;

            alaphelyzetButton.Click += alaphelyzetButton_Click;
            kilepesButton.Click += kilepesButton_Click;
        }


        private void KoszonjButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nevTextBox.Text))
            {
                string koszones = $"Szia, {nevTextBox.Text}!";
                UdvozlesLabel.Text = koszones;
            }
            else
            {
                MessageBox.Show("Kérlek, add meg a nevedet!");
            }
        }
        private void SzinLabelClick(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                this.BackColor = clickedLabel.BackColor;
            }
        }

        private void alaphelyzetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void kilepesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
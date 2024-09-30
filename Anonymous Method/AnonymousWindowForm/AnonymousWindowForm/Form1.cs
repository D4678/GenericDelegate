namespace AnonymousWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button Button1 = new Button();
            Button1.Text = "click Me";
            Button1.Click += delegate
            {
                MessageBox.Show("Hello, You Just Click me!");
            };
            this.Controls.Add(Button1); // This line add a button dynamically
        }

    }
}

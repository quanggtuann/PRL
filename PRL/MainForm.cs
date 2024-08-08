namespace PRL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            GenForm gf = new GenForm();
            gf.TopLevel = false;
            pn_show.Controls.Add(gf);
            gf.FormBorderStyle = FormBorderStyle.None;
            gf.Location = new Point(120, 100);
            gf.Show();
        }

        private void btntesst_Click(object sender, EventArgs e)
        {
            //pn_show.Controls.Clear();
            //    Testform tf = new Testform();
            //    tf.TopLevel = false;
            //    pn_show.Controls.Add(tf);
            //    tf.FormBorderStyle = FormBorderStyle.None;
            //    tf.Show();
        }
    }
}

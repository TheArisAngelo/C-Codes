namespace URL_Picture_Viewer_Gelo
{
    public partial class Form1 : Form
    {

        string[] url = File.ReadLines("Image_URL.txt").ToArray();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            i = url.Length - 1;
            pictureBox1.Load(url[i]);
            label1.Text = "Image " + (i + 1) + " of " + url.Length;
        }

        private void ChangeImageEvent(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
            }
            else
            {
                i = url.Length - 1;
            }

            pictureBox1.Load(url[i + 1]);
            label1.Text = "Image " + (i) + " of " + url.Length;
        }
    }
}

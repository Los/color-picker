using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            LinkLabel.Link stewieLink = new LinkLabel.Link();
            stewieLink.LinkData = "http://forum.sa-mp.com/member.php?u=108849";
            stewieLinkLabel.Links.Add(stewieLink);

            LinkLabel.Link redLink = new LinkLabel.Link();
            redLink.LinkData = "http://forum.sa-mp.com/member.php?u=125572";
            redLinkLabel.Links.Add(redLink);

            LinkLabel.Link freeLink = new LinkLabel.Link();
            freeLink.LinkData = "http://forum.sa-mp.com/member.php?u=132032";
            freeLinkLabel.Links.Add(freeLink);
        }

        private void stewieLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void redLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void freeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.sa-mp.com/member.php?u=104612");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.sa-mp.com/member.php?u=243");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://code.google.com/p/sa-colorpicker/");
        }
    }
}

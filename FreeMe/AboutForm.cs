using System;
using System.Windows.Forms;

namespace FreeMe
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void AboutForm_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void AboutForm_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}

using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FreeMe
{
    public partial class EasterEgg1 : Form
    {
        public EasterEgg1()
        {
            InitializeComponent();
        }

        Bitmap bmp = new Bitmap(Properties.Resources.cuac);
        int counter;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;
            
            try
            {
                SoundPlayer sndPlayer = new SoundPlayer(FreeMe.Properties.Resources.quack);
                sndPlayer.Play(); //cuack
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message - " + ex.Message);
            }

            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = bmp;
            }

            if (counter == 1)
            {
                MessageBox.Show("No toques al pato D:", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter++;
            }
                
            if (counter == 5)
            {
                MessageBox.Show("No le gusta que lo toquen!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                counter++;
            }
                
            if (counter == 10)
            {
                MessageBox.Show("Vas a hacer que se enoje :(", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter++;
            }
                
            if (counter == 15)
            {
                MessageBox.Show("No quieres ver un pato enojado -_-", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                counter++;
            }

            if (counter == 17)
            {
                MessageBox.Show("Bueno ya basta!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter++;
            }

            if (counter == 22)
            {
                MessageBox.Show("Viste, lo espantaste. Gracias ¬¬", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
                MessageBox.Show("t(°-°t)", "Forro!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }
    }
}

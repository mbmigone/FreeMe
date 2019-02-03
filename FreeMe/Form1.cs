using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;

namespace FreeMe
{
    
    public partial class Form1 : Form
    {
        string ajá = "No se supone que estés leyendo esto" +
            "Pero bueno, si llegaste hasta aquí el código fuente está en github " +
            "https://github.com/mbmigone/FreeMe";
        
        //variables de control de flujo. Que los popup se ejecuten una sola vez.
        bool executed1, executed2, executed3, executed4, executed5, executed6=true;
        bool disable; // Para deshabilitar los mensajes y sonidos: modo piola.
        int egcount; //Conteo de acceso al eg.
        
        //Variables del Form1 que se mapean con las del form Reminders
        public int recHoras, recMinutos; 
        public string recMensaje;

        

        // ruta del registro para iniciar con el arranque del sistema.
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan Span = new TimeSpan(18, 15, 0); //Hora de salida = 18:15
            DateTime hoy = DateTime.Now; //La fecha/hora actuales
            TimeSpan ahora = hoy.TimeOfDay; //La hora actual
            TimeSpan result = Span - ahora; // Hora de salida - Hora actual = Tiempo restante para irse
            int resultInt;

            resultInt = Convert.ToInt32(result.TotalSeconds);
            if (resultInt > 43200)
            {
                resultInt = 43200;
                circularProgressBar.PerformStep();
            }
                

            if(resultInt >= 0)
            {
                circularProgressBar.ProgressColor = Color.LimeGreen;
                circularProgressBar.Value = resultInt;
            }
            else
            {
                circularProgressBar.ProgressColor = Color.Crimson;
                circularProgressBar.Value = -1*resultInt;
            }
            
            circularProgressBar.Text = result.ToString(@"h\:mm\:ss");
            

            //lbRemain.Text = result.ToString(@"h\:mm\:ss"); //result se convierte a String para mostrarlo en el Form1

            // Tooltip del icono de la barra de sistema. Mouse Hover muestra el tiempo restante sin abrir el programa.
            notifyIcon1.Text = "FreeMe: " + circularProgressBar.Text;
            
            //Si se llego a la hora de salida (Hora de salida - Hora actual = 0).
            if (result.Hours <= 0 && result.Minutes == 0 && result.Seconds == 0 && !executed1)
            {
                try
                {
                    SoundPlayer sndPlayer = new SoundPlayer(FreeMe.Properties.Resources.ibelieve);
                    if (!disable)
                        sndPlayer.Play(); //Toca I Believe I can fly...
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message - " + ex.Message); //por si acaso no mas.
                }
                //Trae la ventana del programa al frente
                Show();
                WindowState = FormWindowState.Normal;
                executed1 = true;
            }

            //Una hora antes de la salida avisa que queda poco.
            if (result.Hours == 1 && result.Minutes == 0 && result.Seconds == 0 && !executed2)
            {
                notifyIcon1.BalloonTipText = "Ya queda poco :D";
                if (!disable)
                    notifyIcon1.ShowBalloonTip(1000);
                executed2 = true;
            }

            //15 minutos antes de la salida avisa para ir guardando y cerrando.
            if(result.Hours == 0 && result.Minutes == 15 && result.Seconds == 0 && !executed3)
            {
                notifyIcon1.BalloonTipText = "Anda arreglando tus weaitas y apagando";
                if (!disable)
                    notifyIcon1.ShowBalloonTip(1000);
                executed3 = true;
            }

            //Despues de pasada la hora de salida se muestra el tiempo adicional que se ha estado.
            if (ahora.Hours >= 18 && ahora.Minutes >= 15 && !executed4)
            {
                gbRestante.Text = "Tiempo adicional en la oficina:";
                lbMensaje.Text = "Qué estai haciendo acá todavia? FUERA";
                executed4 = true;
            }

            //Despues de pasada la hora de salida se muestra el tiempo adicional que se ha estado.
            if (ahora.Hours >= 20 && ahora.Minutes >= 00 && !executed5)
            {
                gbRestante.Text = "Tiempo adicional en la oficina:";
                lbMensaje.Text = "Todavia por acá? en serio? -_-";
                executed5 = true;
            }

            //Se muestra el recordatorio creado en el form Reminders.
            if (ahora.Hours == recHoras && ahora.Minutes == recMinutos && !executed6)
            {
                executed6 = true;
                MessageBox.Show(
                    "Me pediste que te recuerde que:\n\n" + recMensaje,
                    "Recordatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Reestablece el color del botón luego de mostrar el recordatorio.
                button2.BackColor = SystemColors.Control;
            }
        }

        private void cbAutoRun_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbAutoRun.Checked)
            {
                reg.SetValue("FreeMe", Application.ExecutablePath.ToString());
                MessageBox.Show("Se iniciará al arrancar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                reg.DeleteValue("FreeMe", false);
                MessageBox.Show("Si querí no ma...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EasterEgg1 eg = new EasterEgg1();
            egcount++;
            if (egcount < 5)
            {
                eg.Show();
            }
            else if(egcount >= 5)
            {
                if (MessageBox.Show("Te gusta la weaita." + "\n" + "Deja tranquilo al pobre pato wn o_o", "Yaaa...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                {
                    eg.Show();
                }
            }
                
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Guarda la opción de deshabilitar al momento de salir de la aplicación.
            Properties.Settings.Default.cbDisabled = cbDisable.Checked;
            Properties.Settings.Default.Save();

        }

        private void cbDisable_CheckedChanged(object sender, EventArgs e)
        {
            disable = cbDisable.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reminders rem = new Reminders(); //Nueva instancia de Reminders.

            //Carga de los valores de recordatorio hacia el form Reminders.
            rem.remMensaje = recMensaje;
            rem.remHora = recHoras;
            rem.remMinutos = recMinutos;

            //Se trae los valores del form Reminders hacia el Form1.
            if(rem.ShowDialog() == DialogResult.OK)
            {
                recMensaje = rem.remMensaje;
                recHoras = rem.remHora;
                recMinutos = rem.remMinutos;

                //Cambia el color del botón a verde si hay un recordatorio pendiente.
                button2.BackColor = Color.LightGreen; 
                executed6 = false;
            }
        }

        //Al momento de cargar la ventana principal del programa:
        private void Form1_Load(object sender, EventArgs e)
        {
            // Revisar si estaba tickeado el checkbox de deshabilitar.
            cbDisable.Checked = Properties.Settings.Default.cbDisabled;

            //Revisa si está el registro de iniciar con el sistema
            if (reg.GetValue("FreeMe") == null)
            {
                cbAutoRun.Checked = false;
            }
            else
            {
                cbAutoRun.Checked = true;
            }

            //Inicia el timer.
            timer.Start();
           
            //Setea algunas cosas de mensajes
            notifyIcon1.BalloonTipTitle = "FreeMe";
            notifyIcon1.BalloonTipText = "Yo me quedo por aquí...";
            notifyIcon1.Text = "FreeMe";

            try
            {
                SoundPlayer sndPlayer = new SoundPlayer(FreeMe.Properties.Resources.hellodark);
                if (!disable)
                    sndPlayer.Play(); //Toca Hello Darkness my old friend...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message - " + ex.Message);
            }
        }

        //Doble clic en el icono de sistema
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Trae el programa al frente
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        //Cambio de tamaño del Form1
        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                //Si se trata de un minimizado oculta la ventana en la barra de sistema. 
                Hide();
                notifyIcon1.Visible = true;
                if (!disable)
                    notifyIcon1.ShowBalloonTip(1000);
            }
            else if(FormWindowState.Normal == WindowState)
            {
                //Si fue un normalizado de ventana, oculta el icono de sistema
                notifyIcon1.Visible = false;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clic derecho sobre el icono de sistema contiene una opción para cerrar el programa
            this.Close();
        }
    }
}

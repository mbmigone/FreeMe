using System;
using System.Windows.Forms;

namespace FreeMe
{
    public partial class Reminders : Form
    {
        public Reminders()
        {
            InitializeComponent();
        }

        // Variables públicas para el traspaso de los valores del recordatorio.
        public int remHora, remMinutos;
        public string remMensaje;

        /* Al cargar el form Reminders se setean los valores del recordatorio enviados por el evento de
         clic en el botón Avisame del Form1 */
        private void Reminders_Load(object sender, EventArgs e)
        {
            nudHora.Value = remHora;
            nudMinutos.Value = remMinutos;
            tbRecordatorio.Text = remMensaje;
        }
        /* Al hacer clic en el botón Avisame del form Reminders se invocan setean los valores
         de las propiedades */
        private void btAvisame_Click(object sender, EventArgs e)
        {
            SendMessage = tbRecordatorio.Text;
            SendHours = (int)nudHora.Value;
            SendMinutes = (int)nudMinutos.Value;
        }

        public string SendMessage
        {
            get
            {
                return remMensaje;
            }
            set
            {
                remMensaje = value;
            }
        }

        public int SendHours
        {
            get
            {
                return remHora;
            }
            set
            {
                remHora = value;
            }
        }

        public int SendMinutes
        {
            get
            {
                return remMinutos;
            }
            set
            {
                remMinutos = value;
            }
        }

    }
}

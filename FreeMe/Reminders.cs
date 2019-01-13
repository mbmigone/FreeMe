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

        public int remHora, remMinutos;
        public string remMensaje;

        private void btAvisame_Click(object sender, EventArgs e)
        {
            SendMessage = tbRecordatorio.Text;
            SendHours = (int)nudHora.Value;
            SendMinutes = (int)nudMinutos.Value;
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

        private void Reminders_Load(object sender, EventArgs e)
        {
            nudHora.Value = remHora;
            nudMinutos.Value = remMinutos;
            tbRecordatorio.Text = remMensaje;
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

        
    }
}

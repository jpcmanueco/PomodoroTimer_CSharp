using System;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroTImer_CSharp
{
    public partial class PomodoroTimer : Form
    {
        private int timeLeft;
        private bool isRunning = false;

        public PomodoroTimer()
        {
            InitializeComponent();
            // Configuración del temporizador
            Temporizador.Interval = 1000; // 1 segundo
            Temporizador.Tick += Temporizador_Tick;

            // Inicializa los elementos de TimerdomainUpDown
            for (int i = 1; i <= 60; i++)
            {
                TimerdomainUpDown.Items.Add($"{i}:00");
            }
            TimerdomainUpDown.SelectedItem = "25:00"; // Selección predeterminada
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (TimerdomainUpDown.SelectedItem == "" || TimerdomainUpDown.SelectedItem == null)
            {
                MessageBox.Show("El tiempo establecido ha diso de 1:00 ");
                TimerdomainUpDown.SelectedItem = "1:00"; 
            }
            string selectedTime = TimerdomainUpDown.SelectedItem.ToString();
            string[] parts = selectedTime.Split(':');
            timeLeft = int.Parse(parts[0]) * 60; // Convertir a segundos
            Timerlabel.Text = $"{parts[0]}:00"; // Mostrar tiempo inicial
            isRunning = true;
            Temporizador.Start();
            TimerdomainUpDown.Enabled = false;
            Startbutton.Enabled = false;
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                if (timeLeft > 0)
                {
                    timeLeft--;
                    Timerlabel.Text = $"{timeLeft / 60:D2}:{timeLeft % 60:D2}";
                }
                else
                {
                    Temporizador.Stop();
                    isRunning = false;
                    MessageBox.Show("¡Tiempo terminado!");
                    Startbutton.Enabled = true;
                    TimerdomainUpDown.Enabled = true;
                }
            }
        }

        private void Pausebutton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                Temporizador.Stop();
                Pausebutton.Text = "Continuar";
            }
            else
            {
                isRunning = true;
                Temporizador.Start();
                Pausebutton.Text = "Pausar";
            }
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            isRunning = false;
            Temporizador.Stop();
            timeLeft = 0;
            Timerlabel.Text = "00:00";
            Startbutton.Enabled = true;
            TimerdomainUpDown.Enabled = true;
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones:\n\n1. Selecciona el tiempo en minutos.\n2. Haz clic en 'Start' para iniciar el temporizador.\n3. Usa 'Pause' para pausar y 'Continue' para reanudar.\n4. Haz clic en 'Stop' para reiniciar el temporizador.", "Acerca de");
        }

        private void PomodorocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PomodorocheckBox.Checked)
            {
                TimerdomainUpDown.SelectedItem = "45:00";
            }
        }
    }
}

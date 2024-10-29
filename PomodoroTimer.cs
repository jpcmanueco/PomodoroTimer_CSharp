using System;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroTImer_CSharp
{
    public partial class PomodoroTimer : Form
    {
        private int timeLeft; // Tiempo restante en segundos
        private bool isRunning = false; // Estado del temporizador

        public PomodoroTimer()
        {
            InitializeComponent();

            // Inicializar el Temporizador
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 1000 // Intervalo de 1 segundo
            };
            Temporizador.Tick += Temporizador_Tick; // Conectar el evento Tick

            // Configurar el DomainUpDown
            for (int i = 1; i <= 60; i++)
            {
                domainUpDown1.Items.Add($"{i}:00");
            }
            domainUpDown1.Items.Add("45:00"); // Agregar 45 minutos
            domainUpDown1.SelectedItem = "25:00"; // Selección predeterminada
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedItem != null)
            {
                string selectedTime = domainUpDown1.SelectedItem.ToString();
                string[] parts = selectedTime.Split(':');
                timeLeft = int.Parse(parts[0]) * 60; // Convertir a segundos
                Timerlabel.Text = $"{parts[0]}:00"; // Mostrar tiempo inicial
                isRunning = true;
                Temporizador.Start(); // Iniciar el temporizador
                domainUpDown1.Enabled = false; // Deshabilitar el cambio de tiempo
                Startbutton.Enabled = false; // Deshabilitar el botón de inicio
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                if (timeLeft > 0)
                {
                    timeLeft--;
                    Timerlabel.Text = $"{timeLeft / 60:D2}:{timeLeft % 60:D2}"; // Actualizar el label
                }
                else
                {
                    Temporizador.Stop(); // Detener el temporizador
                    isRunning = false; // Actualizar el estado
                    MessageBox.Show("¡Tiempo terminado!");
                    Startbutton.Enabled = true; // Habilitar el botón de inicio
                    domainUpDown1.Enabled = true; // Habilitar el DomainUpDown
                }
            }
        }

        private void Pausebutton_Click(object sender, EventArgs e) // Pausar / Continuar
        {
            if (isRunning)
            {
                isRunning = false;
                Temporizador.Stop(); // Detener el temporizador
                Pausebutton.Text = "Continuar"; // Cambiar texto a "Continuar"
            }
            else
            {
                isRunning = true;
                Temporizador.Start(); // Reiniciar el temporizador
                Pausebutton.Text = "Pausar"; // Cambiar texto a "Pausar"
            }
        }

        private void Stopbutton_Click(object sender, EventArgs e) // Stop
        {
            isRunning = false;
            Temporizador.Stop(); // Detener el temporizador
            timeLeft = 0; // Reiniciar el tiempo
            Timerlabel.Text = "00:00"; // Reiniciar el label
            Startbutton.Enabled = true; // Habilitar el botón de inicio
            domainUpDown1.Enabled = true; // Habilitar el DomainUpDown
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones:\n\n1. Selecciona el tiempo en minutos.\n2. Haz clic en 'Start' para iniciar el temporizador.\n3. Usa 'Pause' para pausar y 'Continue' para reanudar.\n4. Haz clic en 'Stop' para reiniciar el temporizador.", "Acerca de");
        }
    }
}

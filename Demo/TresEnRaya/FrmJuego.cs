namespace TresEnRaya
{
    public partial class FrmJuego : Form
    {
        bool turnoJugadorX;
        int turnos;
        Button[] botones;

        public FrmJuego()
        {
            InitializeComponent();
            turnos = 0;
            turnoJugadorX = new Random().Next(2) == 0;
            lblTurno.Text = "Turno: " + (turnoJugadorX ? "X" : "O");
            botones = [btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9];
        }

        private void marcar_Click(object sender, EventArgs e)
        {
            Button botonClickeado = (Button)sender;
            if (botonClickeado.Text == "")
            {
                botonClickeado.Text = turnoJugadorX ? "X" : "O";
                lblTurno.Text = "Turno: " + (turnoJugadorX ? "O" : "X");

                turnoJugadorX = !turnoJugadorX;
                turnos++;
                botonClickeado.Enabled = false;
                lblTurno.Focus();
                comprobarGanador();
            }
        }

        private void comprobarGanador()
        {
            bool hayGanador = false;

            int[,] combinaciones = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7 ,8 }, // Filas
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columnas
                { 0, 4, 8 }, { 2, 4, 6 }               // Diagonales
            };

            for (int i = 0; i < combinaciones.GetLength(0); i++)
            {
                int coincidencia1 = combinaciones[i, 0];
                int coincidencia2 = combinaciones[i, 1];
                int coincidencia3 = combinaciones[i, 2];

                if (botones[coincidencia1].Text != "" &&
                    botones[coincidencia1].Text == botones[coincidencia2].Text &&
                    botones[coincidencia2].Text == botones[coincidencia3].Text)
                {
                    MessageBox.Show($"¡El jugador {botones[coincidencia1].Text} ha ganado!",
                        "Juego Terminado!");
                    hayGanador = true;
                    deshabilitarBotones();
                    actualizarResultados(botones[coincidencia1].Text);
                    break;
                }
            }

            if (!hayGanador && turnos == 9)
            {
                MessageBox.Show("¡Empate!", "Juego Terminado");
                actualizarResultados("");
            }
        }

        private void deshabilitarBotones()
        {
            foreach (Button boton in botones) boton.Enabled = false;
        }

        private void actualizarResultados(string ganador)
        {
            if (ganador == "X")
            {
                lblVictoriasX.Text = (int.Parse(lblVictoriasX.Text) + 1).ToString();
            }
            else if (ganador == "O")
            {
                lblVictoriasO.Text = (int.Parse(lblVictoriasO.Text) + 1).ToString();
            }
            else
            {
                lblEmpates.Text = (int.Parse(lblEmpates.Text) + 1).ToString();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            turnos = 0;
            turnoJugadorX = new Random().Next(2) == 0;
            lblTurno.Text = "Turno: " + (turnoJugadorX ? "X" : "O");

            foreach (Button boton in botones)
            {
                boton.Text = "";
                boton.Enabled = true;
            }
        }
    }
}

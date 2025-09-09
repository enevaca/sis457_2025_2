namespace TresEnRaya
{
    partial class FrmJuego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            lblTurno = new Label();
            label2 = new Label();
            lblEmpates = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblVictoriasX = new Label();
            lblVictoriasO = new Label();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 48);
            label1.TabIndex = 0;
            label1.Text = "Tres en Raya";
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn1.Location = new Point(84, 111);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += marcar_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn2.Location = new Point(170, 111);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += marcar_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn3.Location = new Point(256, 111);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += marcar_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn6.Location = new Point(256, 197);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += marcar_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn5.Location = new Point(170, 197);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += marcar_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn4.Location = new Point(84, 197);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 4;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += marcar_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn9.Location = new Point(256, 283);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 9;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += marcar_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn8.Location = new Point(170, 283);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += marcar_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn7.Location = new Point(84, 283);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += marcar_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(170, 67);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(81, 25);
            lblTurno.TabIndex = 10;
            lblTurno.Text = "Turno: --";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 67);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 11;
            label2.Text = "Empates:";
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.Location = new Point(103, 67);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(22, 25);
            lblEmpates.TabIndex = 12;
            lblEmpates.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 406);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 13;
            label3.Text = "Jugador X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 406);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 14;
            label4.Text = "Jugador O";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 439);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 15;
            label5.Text = "Victorias:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 439);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 16;
            label6.Text = "Victorias:";
            // 
            // lblVictoriasX
            // 
            lblVictoriasX.AutoSize = true;
            lblVictoriasX.Location = new Point(103, 439);
            lblVictoriasX.Name = "lblVictoriasX";
            lblVictoriasX.Size = new Size(22, 25);
            lblVictoriasX.TabIndex = 17;
            lblVictoriasX.Text = "0";
            // 
            // lblVictoriasO
            // 
            lblVictoriasO.AutoSize = true;
            lblVictoriasO.Location = new Point(347, 439);
            lblVictoriasO.Name = "lblVictoriasO";
            lblVictoriasO.Size = new Size(22, 25);
            lblVictoriasO.TabIndex = 18;
            lblVictoriasO.Text = "0";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(151, 369);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(112, 34);
            btnReiniciar.TabIndex = 19;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // FrmJuego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(409, 477);
            Controls.Add(btnReiniciar);
            Controls.Add(lblVictoriasO);
            Controls.Add(lblVictoriasX);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblEmpates);
            Controls.Add(label2);
            Controls.Add(lblTurno);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego Tres en Raya";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label lblTurno;
        private Label label2;
        private Label lblEmpates;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblVictoriasX;
        private Label lblVictoriasO;
        private Button btnReiniciar;
    }
}

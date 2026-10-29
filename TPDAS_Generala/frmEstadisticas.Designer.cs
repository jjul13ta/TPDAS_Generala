namespace TPDAS_Generala
{
    partial class frmEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.pnlGanadas = new System.Windows.Forms.Panel();
            this.lblGanadas = new System.Windows.Forms.Label();
            this.lblGanadasTitulo = new System.Windows.Forms.Label();
            this.pnlPerdidas = new System.Windows.Forms.Panel();
            this.lblPerdidas = new System.Windows.Forms.Label();
            this.lblPerdidasTitulo = new System.Windows.Forms.Label();
            this.pnlEmpatadas = new System.Windows.Forms.Panel();
            this.lblEmpatadas = new System.Windows.Forms.Label();
            this.lblEmpatadasTitulo = new System.Windows.Forms.Label();
            this.lblJugadasTitulo = new System.Windows.Forms.Label();
            this.lblJugadas = new System.Windows.Forms.Label();
            this.lblPromedioTitulo = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTiempoTitulo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.barPromedio = new System.Windows.Forms.ProgressBar();
            this.pnlGanadas.SuspendLayout();
            this.pnlPerdidas.SuspendLayout();
            this.pnlEmpatadas.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estadísticas";
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblUsuario.Location = new System.Drawing.Point(22, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Jugador";
            //
            // cmbUsuario
            //
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(25, 80);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(240, 28);
            this.cmbUsuario.TabIndex = 2;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            //
            // pnlGanadas
            //
            this.pnlGanadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlGanadas.Controls.Add(this.lblGanadas);
            this.pnlGanadas.Controls.Add(this.lblGanadasTitulo);
            this.pnlGanadas.Location = new System.Drawing.Point(25, 128);
            this.pnlGanadas.Name = "pnlGanadas";
            this.pnlGanadas.Size = new System.Drawing.Size(130, 90);
            this.pnlGanadas.TabIndex = 3;
            //
            // lblGanadas
            //
            this.lblGanadas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblGanadas.ForeColor = System.Drawing.Color.White;
            this.lblGanadas.Location = new System.Drawing.Point(0, 30);
            this.lblGanadas.Name = "lblGanadas";
            this.lblGanadas.Size = new System.Drawing.Size(130, 50);
            this.lblGanadas.TabIndex = 1;
            this.lblGanadas.Text = "0";
            this.lblGanadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblGanadasTitulo
            //
            this.lblGanadasTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGanadasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblGanadasTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblGanadasTitulo.Name = "lblGanadasTitulo";
            this.lblGanadasTitulo.Size = new System.Drawing.Size(130, 20);
            this.lblGanadasTitulo.TabIndex = 0;
            this.lblGanadasTitulo.Text = "GANADAS";
            this.lblGanadasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlPerdidas
            //
            this.pnlPerdidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlPerdidas.Controls.Add(this.lblPerdidas);
            this.pnlPerdidas.Controls.Add(this.lblPerdidasTitulo);
            this.pnlPerdidas.Location = new System.Drawing.Point(165, 128);
            this.pnlPerdidas.Name = "pnlPerdidas";
            this.pnlPerdidas.Size = new System.Drawing.Size(130, 90);
            this.pnlPerdidas.TabIndex = 4;
            //
            // lblPerdidas
            //
            this.lblPerdidas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPerdidas.ForeColor = System.Drawing.Color.White;
            this.lblPerdidas.Location = new System.Drawing.Point(0, 30);
            this.lblPerdidas.Name = "lblPerdidas";
            this.lblPerdidas.Size = new System.Drawing.Size(130, 50);
            this.lblPerdidas.TabIndex = 1;
            this.lblPerdidas.Text = "0";
            this.lblPerdidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblPerdidasTitulo
            //
            this.lblPerdidasTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPerdidasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblPerdidasTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblPerdidasTitulo.Name = "lblPerdidasTitulo";
            this.lblPerdidasTitulo.Size = new System.Drawing.Size(130, 20);
            this.lblPerdidasTitulo.TabIndex = 0;
            this.lblPerdidasTitulo.Text = "PERDIDAS";
            this.lblPerdidasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlEmpatadas
            //
            this.pnlEmpatadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.pnlEmpatadas.Controls.Add(this.lblEmpatadas);
            this.pnlEmpatadas.Controls.Add(this.lblEmpatadasTitulo);
            this.pnlEmpatadas.Location = new System.Drawing.Point(305, 128);
            this.pnlEmpatadas.Name = "pnlEmpatadas";
            this.pnlEmpatadas.Size = new System.Drawing.Size(130, 90);
            this.pnlEmpatadas.TabIndex = 5;
            //
            // lblEmpatadas
            //
            this.lblEmpatadas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblEmpatadas.ForeColor = System.Drawing.Color.White;
            this.lblEmpatadas.Location = new System.Drawing.Point(0, 30);
            this.lblEmpatadas.Name = "lblEmpatadas";
            this.lblEmpatadas.Size = new System.Drawing.Size(130, 50);
            this.lblEmpatadas.TabIndex = 1;
            this.lblEmpatadas.Text = "0";
            this.lblEmpatadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblEmpatadasTitulo
            //
            this.lblEmpatadasTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpatadasTitulo.ForeColor = System.Drawing.Color.White;
            this.lblEmpatadasTitulo.Location = new System.Drawing.Point(0, 8);
            this.lblEmpatadasTitulo.Name = "lblEmpatadasTitulo";
            this.lblEmpatadasTitulo.Size = new System.Drawing.Size(130, 20);
            this.lblEmpatadasTitulo.TabIndex = 0;
            this.lblEmpatadasTitulo.Text = "EMPATADAS";
            this.lblEmpatadasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblJugadasTitulo
            //
            this.lblJugadasTitulo.AutoSize = true;
            this.lblJugadasTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJugadasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblJugadasTitulo.Location = new System.Drawing.Point(22, 238);
            this.lblJugadasTitulo.Name = "lblJugadasTitulo";
            this.lblJugadasTitulo.Size = new System.Drawing.Size(115, 19);
            this.lblJugadasTitulo.TabIndex = 6;
            this.lblJugadasTitulo.Text = "Partidas jugadas";
            //
            // lblJugadas
            //
            this.lblJugadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblJugadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblJugadas.Location = new System.Drawing.Point(235, 236);
            this.lblJugadas.Name = "lblJugadas";
            this.lblJugadas.Size = new System.Drawing.Size(200, 23);
            this.lblJugadas.TabIndex = 7;
            this.lblJugadas.Text = "0";
            this.lblJugadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblPromedioTitulo
            //
            this.lblPromedioTitulo.AutoSize = true;
            this.lblPromedioTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPromedioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblPromedioTitulo.Location = new System.Drawing.Point(22, 270);
            this.lblPromedioTitulo.Name = "lblPromedioTitulo";
            this.lblPromedioTitulo.Size = new System.Drawing.Size(140, 19);
            this.lblPromedioTitulo.TabIndex = 8;
            this.lblPromedioTitulo.Text = "Promedio de victorias";
            //
            // lblPromedio
            //
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblPromedio.Location = new System.Drawing.Point(235, 268);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(200, 23);
            this.lblPromedio.TabIndex = 9;
            this.lblPromedio.Text = "0 %";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // barPromedio
            //
            this.barPromedio.Location = new System.Drawing.Point(25, 296);
            this.barPromedio.Name = "barPromedio";
            this.barPromedio.Size = new System.Drawing.Size(410, 10);
            this.barPromedio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barPromedio.TabIndex = 10;
            //
            // lblTiempoTitulo
            //
            this.lblTiempoTitulo.AutoSize = true;
            this.lblTiempoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTiempoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblTiempoTitulo.Location = new System.Drawing.Point(22, 320);
            this.lblTiempoTitulo.Name = "lblTiempoTitulo";
            this.lblTiempoTitulo.Size = new System.Drawing.Size(132, 19);
            this.lblTiempoTitulo.TabIndex = 11;
            this.lblTiempoTitulo.Text = "Tiempo total jugado";
            //
            // lblTiempo
            //
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblTiempo.Location = new System.Drawing.Point(235, 318);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(200, 23);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "00:00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // frmEstadisticas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(460, 366);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTiempoTitulo);
            this.Controls.Add(this.barPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblPromedioTitulo);
            this.Controls.Add(this.lblJugadas);
            this.Controls.Add(this.lblJugadasTitulo);
            this.Controls.Add(this.pnlEmpatadas);
            this.Controls.Add(this.pnlPerdidas);
            this.Controls.Add(this.pnlGanadas);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEstadisticas";
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.pnlGanadas.ResumeLayout(false);
            this.pnlPerdidas.ResumeLayout(false);
            this.pnlEmpatadas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Panel pnlGanadas;
        private System.Windows.Forms.Label lblGanadas;
        private System.Windows.Forms.Label lblGanadasTitulo;
        private System.Windows.Forms.Panel pnlPerdidas;
        private System.Windows.Forms.Label lblPerdidas;
        private System.Windows.Forms.Label lblPerdidasTitulo;
        private System.Windows.Forms.Panel pnlEmpatadas;
        private System.Windows.Forms.Label lblEmpatadas;
        private System.Windows.Forms.Label lblEmpatadasTitulo;
        private System.Windows.Forms.Label lblJugadasTitulo;
        private System.Windows.Forms.Label lblJugadas;
        private System.Windows.Forms.Label lblPromedioTitulo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ProgressBar barPromedio;
        private System.Windows.Forms.Label lblTiempoTitulo;
        private System.Windows.Forms.Label lblTiempo;
    }
}

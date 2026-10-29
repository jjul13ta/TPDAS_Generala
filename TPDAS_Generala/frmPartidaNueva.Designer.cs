namespace TPDAS_Generala
{
    partial class frmPartidaNueva
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
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cmbJugador1 = new System.Windows.Forms.ComboBox();
            this.cmbJugador2 = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblJugador1
            //
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblJugador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblJugador1.Location = new System.Drawing.Point(24, 92);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(73, 17);
            this.lblJugador1.TabIndex = 2;
            this.lblJugador1.Text = "Jugador 1";
            //
            // lblJugador2
            //
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblJugador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblJugador2.Location = new System.Drawing.Point(254, 92);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(73, 17);
            this.lblJugador2.TabIndex = 4;
            this.lblJugador2.Text = "Jugador 2";
            //
            // btnIniciar
            //
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(304, 170);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 40);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "¡A jugar!";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            //
            // cmbJugador1
            //
            this.cmbJugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJugador1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbJugador1.FormattingEnabled = true;
            this.cmbJugador1.Location = new System.Drawing.Point(27, 113);
            this.cmbJugador1.Name = "cmbJugador1";
            this.cmbJugador1.Size = new System.Drawing.Size(200, 28);
            this.cmbJugador1.TabIndex = 3;
            //
            // cmbJugador2
            //
            this.cmbJugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJugador2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbJugador2.FormattingEnabled = true;
            this.cmbJugador2.Location = new System.Drawing.Point(257, 113);
            this.cmbJugador2.Name = "cmbJugador2";
            this.cmbJugador2.Size = new System.Drawing.Size(200, 28);
            this.cmbJugador2.TabIndex = 5;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(188, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nueva partida";
            //
            // lblAyuda
            //
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblAyuda.Location = new System.Drawing.Point(23, 52);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(320, 15);
            this.lblAyuda.TabIndex = 1;
            this.lblAyuda.Text = "Elegí los dos jugadores entre los usuarios con sesión iniciada.";
            //
            // lblVs
            //
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.lblVs.Location = new System.Drawing.Point(231, 118);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(22, 17);
            this.lblVs.TabIndex = 8;
            this.lblVs.Text = "vs";
            //
            // frmPartidaNueva
            //
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(484, 232);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbJugador2);
            this.Controls.Add(this.cmbJugador1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPartidaNueva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva partida";
            this.Load += new System.EventHandler(this.frmPartidaNueva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cmbJugador1;
        private System.Windows.Forms.ComboBox cmbJugador2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblVs;
    }
}

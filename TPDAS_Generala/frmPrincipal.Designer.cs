namespace TPDAS_Generala
{
    partial class frmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            this.SuspendLayout();
            //
            // menuPrincipal
            //
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuJuego,
            this.mnuConsultas,
            this.mnuAdministracion,
            this.mnuVentanas});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.MdiWindowListItem = this.mnuVentanas;
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuPrincipal.Size = new System.Drawing.Size(1084, 31);
            this.menuPrincipal.TabIndex = 0;
            //
            // mnuUsuarios
            //
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIniciarSesion,
            this.mnuCerrarSesion,
            this.mnuSeparador,
            this.mnuSalir});
            this.mnuUsuarios.ForeColor = System.Drawing.Color.White;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(74, 23);
            this.mnuUsuarios.Text = "&Usuarios";
            //
            // mnuIniciarSesion
            //
            this.mnuIniciarSesion.Name = "mnuIniciarSesion";
            this.mnuIniciarSesion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuIniciarSesion.Size = new System.Drawing.Size(270, 24);
            this.mnuIniciarSesion.Text = "Iniciar sesión / Registrarse";
            this.mnuIniciarSesion.Click += new System.EventHandler(this.mnuIniciarSesion_Click);
            //
            // mnuCerrarSesion
            //
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Size = new System.Drawing.Size(270, 24);
            this.mnuCerrarSesion.Text = "Cerrar sesión";
            this.mnuCerrarSesion.DropDownOpening += new System.EventHandler(this.mnuCerrarSesion_DropDownOpening);
            //
            // mnuSeparador
            //
            this.mnuSeparador.Name = "mnuSeparador";
            this.mnuSeparador.Size = new System.Drawing.Size(267, 6);
            //
            // mnuSalir
            //
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(270, 24);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            //
            // mnuJuego
            //
            this.mnuJuego.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevaPartida});
            this.mnuJuego.ForeColor = System.Drawing.Color.White;
            this.mnuJuego.Name = "mnuJuego";
            this.mnuJuego.Size = new System.Drawing.Size(58, 23);
            this.mnuJuego.Text = "&Juego";
            //
            // mnuNuevaPartida
            //
            this.mnuNuevaPartida.Name = "mnuNuevaPartida";
            this.mnuNuevaPartida.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNuevaPartida.Size = new System.Drawing.Size(218, 24);
            this.mnuNuevaPartida.Text = "Nueva partida";
            this.mnuNuevaPartida.Click += new System.EventHandler(this.mnuNuevaPartida_Click);
            //
            // mnuConsultas
            //
            this.mnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEstadisticas,
            this.mnuBitacora});
            this.mnuConsultas.ForeColor = System.Drawing.Color.White;
            this.mnuConsultas.Name = "mnuConsultas";
            this.mnuConsultas.Size = new System.Drawing.Size(80, 23);
            this.mnuConsultas.Text = "&Consultas";
            //
            // mnuEstadisticas
            //
            this.mnuEstadisticas.Name = "mnuEstadisticas";
            this.mnuEstadisticas.Size = new System.Drawing.Size(158, 24);
            this.mnuEstadisticas.Text = "Estadísticas";
            this.mnuEstadisticas.Click += new System.EventHandler(this.mnuEstadisticas_Click);
            //
            // mnuBitacora
            //
            this.mnuBitacora.Name = "mnuBitacora";
            this.mnuBitacora.Size = new System.Drawing.Size(158, 24);
            this.mnuBitacora.Text = "Bitácora";
            this.mnuBitacora.Click += new System.EventHandler(this.mnuBitacora_Click);
            //
            // mnuAdministracion
            //
            this.mnuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackup});
            this.mnuAdministracion.ForeColor = System.Drawing.Color.White;
            this.mnuAdministracion.Name = "mnuAdministracion";
            this.mnuAdministracion.Size = new System.Drawing.Size(115, 23);
            this.mnuAdministracion.Text = "&Administración";
            //
            // mnuBackup
            //
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(196, 24);
            this.mnuBackup.Text = "Backup y Restore";
            this.mnuBackup.Click += new System.EventHandler(this.mnuBackup_Click);
            //
            // mnuVentanas
            //
            this.mnuVentanas.ForeColor = System.Drawing.Color.White;
            this.mnuVentanas.Name = "mnuVentanas";
            this.mnuVentanas.Size = new System.Drawing.Size(78, 23);
            this.mnuVentanas.Text = "&Ventanas";
            //
            // statusPrincipal
            //
            this.statusPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.statusPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 639);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(1084, 22);
            this.statusPrincipal.TabIndex = 1;
            //
            // lblEstado
            //
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(170, 17);
            this.lblEstado.Text = "Sin usuarios conectados";
            //
            // frmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator mnuSeparador;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuJuego;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaPartida;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem mnuEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem mnuBitacora;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem mnuBackup;
        private System.Windows.Forms.ToolStripMenuItem mnuVentanas;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}

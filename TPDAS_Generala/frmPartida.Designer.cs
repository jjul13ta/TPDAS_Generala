namespace TPDAS_Generala
{
    partial class frmPartida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.btnAnotar = new System.Windows.Forms.Button();
            this.btnTirar = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.uC_DADO5 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO4 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO3 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO2 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO1 = new TPDAS_Generala.UC_DADO();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.pnlMesa.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlEncabezado
            //
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlEncabezado.Controls.Add(this.lblInfo);
            this.pnlEncabezado.Controls.Add(this.lblTurno);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(964, 76);
            this.pnlEncabezado.TabIndex = 0;
            //
            // lblInfo
            //
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblInfo.Location = new System.Drawing.Point(22, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(173, 19);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Ronda 1 de 10  ·  Tirada 0 de 3";
            //
            // lblTurno
            //
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTurno.ForeColor = System.Drawing.Color.White;
            this.lblTurno.Location = new System.Drawing.Point(18, 10);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(150, 31);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno de ...";
            //
            // dgvPlanilla
            //
            this.dgvPlanilla.AllowUserToAddRows = false;
            this.dgvPlanilla.AllowUserToDeleteRows = false;
            this.dgvPlanilla.AllowUserToResizeColumns = false;
            this.dgvPlanilla.AllowUserToResizeRows = false;
            this.dgvPlanilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanilla.ColumnHeadersHeight = 40;
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoria,
            this.colJugador1,
            this.colJugador2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanilla.EnableHeadersVisualStyles = false;
            this.dgvPlanilla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPlanilla.Location = new System.Drawing.Point(20, 120);
            this.dgvPlanilla.MultiSelect = false;
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.ReadOnly = true;
            this.dgvPlanilla.RowHeadersVisible = false;
            this.dgvPlanilla.RowTemplate.Height = 38;
            this.dgvPlanilla.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(420, 460);
            this.dgvPlanilla.TabIndex = 2;
            this.dgvPlanilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanilla_CellDoubleClick);
            //
            // colCategoria
            //
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCategoria.FillWeight = 110F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // colJugador1
            //
            this.colJugador1.HeaderText = "Jugador 1";
            this.colJugador1.Name = "colJugador1";
            this.colJugador1.ReadOnly = true;
            this.colJugador1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // colJugador2
            //
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colJugador2.DefaultCellStyle = dataGridViewCellStyle4;
            this.colJugador2.HeaderText = "Jugador 2";
            this.colJugador2.Name = "colJugador2";
            this.colJugador2.ReadOnly = true;
            this.colJugador2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // pnlMesa
            //
            this.pnlMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlMesa.Controls.Add(this.btnAnotar);
            this.pnlMesa.Controls.Add(this.btnTirar);
            this.pnlMesa.Controls.Add(this.lblAyuda);
            this.pnlMesa.Controls.Add(this.lblMesa);
            this.pnlMesa.Controls.Add(this.uC_DADO5);
            this.pnlMesa.Controls.Add(this.uC_DADO4);
            this.pnlMesa.Controls.Add(this.uC_DADO3);
            this.pnlMesa.Controls.Add(this.uC_DADO2);
            this.pnlMesa.Controls.Add(this.uC_DADO1);
            this.pnlMesa.Location = new System.Drawing.Point(460, 92);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(484, 488);
            this.pnlMesa.TabIndex = 3;
            //
            // btnAnotar
            //
            this.btnAnotar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnotar.BackColor = System.Drawing.Color.White;
            this.btnAnotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotar.FlatAppearance.BorderSize = 0;
            this.btnAnotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnotar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnAnotar.Location = new System.Drawing.Point(22, 416);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(440, 48);
            this.btnAnotar.TabIndex = 8;
            this.btnAnotar.Text = "Anotar en la categoría seleccionada";
            this.btnAnotar.UseVisualStyleBackColor = false;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            //
            // btnTirar
            //
            this.btnTirar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnTirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTirar.FlatAppearance.BorderSize = 0;
            this.btnTirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTirar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnTirar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTirar.Location = new System.Drawing.Point(22, 350);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(440, 56);
            this.btnTirar.TabIndex = 7;
            this.btnTirar.Text = "Tirar dados";
            this.btnTirar.UseVisualStyleBackColor = false;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            //
            // lblAyuda
            //
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblAyuda.Location = new System.Drawing.Point(22, 200);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(440, 60);
            this.lblAyuda.TabIndex = 6;
            this.lblAyuda.Text = "Hacé clic en un dado para retenerlo antes de volver a tirar.\r\nPara anotar, elegí una categoría en la planilla (doble clic o botón Anotar).";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblMesa
            //
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMesa.ForeColor = System.Drawing.Color.White;
            this.lblMesa.Location = new System.Drawing.Point(18, 14);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(49, 21);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Dados";
            //
            // uC_DADO5
            //
            this.uC_DADO5.BackColor = System.Drawing.Color.Transparent;
            this.uC_DADO5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_DADO5.Location = new System.Drawing.Point(378, 80);
            this.uC_DADO5.Name = "uC_DADO5";
            this.uC_DADO5.Numero = 0;
            this.uC_DADO5.Size = new System.Drawing.Size(86, 86);
            this.uC_DADO5.TabIndex = 5;
            //
            // uC_DADO4
            //
            this.uC_DADO4.BackColor = System.Drawing.Color.Transparent;
            this.uC_DADO4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_DADO4.Location = new System.Drawing.Point(289, 80);
            this.uC_DADO4.Name = "uC_DADO4";
            this.uC_DADO4.Numero = 0;
            this.uC_DADO4.Size = new System.Drawing.Size(86, 86);
            this.uC_DADO4.TabIndex = 4;
            //
            // uC_DADO3
            //
            this.uC_DADO3.BackColor = System.Drawing.Color.Transparent;
            this.uC_DADO3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_DADO3.Location = new System.Drawing.Point(200, 80);
            this.uC_DADO3.Name = "uC_DADO3";
            this.uC_DADO3.Numero = 0;
            this.uC_DADO3.Size = new System.Drawing.Size(86, 86);
            this.uC_DADO3.TabIndex = 3;
            //
            // uC_DADO2
            //
            this.uC_DADO2.BackColor = System.Drawing.Color.Transparent;
            this.uC_DADO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_DADO2.Location = new System.Drawing.Point(111, 80);
            this.uC_DADO2.Name = "uC_DADO2";
            this.uC_DADO2.Numero = 0;
            this.uC_DADO2.Size = new System.Drawing.Size(86, 86);
            this.uC_DADO2.TabIndex = 2;
            //
            // uC_DADO1
            //
            this.uC_DADO1.BackColor = System.Drawing.Color.Transparent;
            this.uC_DADO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_DADO1.Location = new System.Drawing.Point(22, 80);
            this.uC_DADO1.Name = "uC_DADO1";
            this.uC_DADO1.Numero = 0;
            this.uC_DADO1.Size = new System.Drawing.Size(86, 86);
            this.uC_DADO1.TabIndex = 1;
            //
            // lblPlanilla
            //
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlanilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblPlanilla.Location = new System.Drawing.Point(16, 92);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(65, 21);
            this.lblPlanilla.TabIndex = 1;
            this.lblPlanilla.Text = "Planilla";
            //
            // frmPartida
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(964, 600);
            this.Controls.Add(this.lblPlanilla);
            this.Controls.Add(this.pnlMesa);
            this.Controls.Add(this.dgvPlanilla);
            this.Controls.Add(this.pnlEncabezado);
            this.MinimumSize = new System.Drawing.Size(980, 639);
            this.Name = "frmPartida";
            this.Text = "Partida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPartida_FormClosing);
            this.Load += new System.EventHandler(this.frmPartida_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.pnlMesa.ResumeLayout(false);
            this.pnlMesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJugador2;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Button btnAnotar;
        private System.Windows.Forms.Label lblPlanilla;
        private UC_DADO uC_DADO1;
        private UC_DADO uC_DADO2;
        private UC_DADO uC_DADO3;
        private UC_DADO uC_DADO4;
        private UC_DADO uC_DADO5;
    }
}

namespace TPDAS_Generala
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_validarIngresos = new System.Windows.Forms.Button();
            this.uC_INGRESOS2 = new TPDAS_Generala.UC_INGRESOS();
            this.uC_INGRESOS1 = new TPDAS_Generala.UC_INGRESOS();
            this.uC_DADO1 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO2 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO3 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO4 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO5 = new TPDAS_Generala.UC_DADO();
            this.SuspendLayout();
            // 
            // btn_validarIngresos
            // 
            this.btn_validarIngresos.Location = new System.Drawing.Point(173, 116);
            this.btn_validarIngresos.Name = "btn_validarIngresos";
            this.btn_validarIngresos.Size = new System.Drawing.Size(75, 23);
            this.btn_validarIngresos.TabIndex = 2;
            this.btn_validarIngresos.Text = "VALIDAR";
            this.btn_validarIngresos.UseVisualStyleBackColor = true;
            this.btn_validarIngresos.Click += new System.EventHandler(this.btn_validarIngresos_Click);
            // 
            // uC_INGRESOS2
            // 
            this.uC_INGRESOS2.Etiqueta = "Password";
            this.uC_INGRESOS2.Location = new System.Drawing.Point(1, 39);
            this.uC_INGRESOS2.Name = "uC_INGRESOS2";
            this.uC_INGRESOS2.Requerido = false;
            this.uC_INGRESOS2.Size = new System.Drawing.Size(273, 71);
            this.uC_INGRESOS2.TabIndex = 1;
            this.uC_INGRESOS2.Texto = "";
            // 
            // uC_INGRESOS1
            // 
            this.uC_INGRESOS1.Etiqueta = "Username";
            this.uC_INGRESOS1.Location = new System.Drawing.Point(1, -8);
            this.uC_INGRESOS1.Name = "uC_INGRESOS1";
            this.uC_INGRESOS1.Requerido = false;
            this.uC_INGRESOS1.Size = new System.Drawing.Size(273, 71);
            this.uC_INGRESOS1.TabIndex = 0;
            this.uC_INGRESOS1.Texto = "";
            // 
            // uC_DADO1
            // 
            this.uC_DADO1.Location = new System.Drawing.Point(1, 155);
            this.uC_DADO1.Name = "uC_DADO1";
            this.uC_DADO1.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO1.TabIndex = 3;
            // 
            // uC_DADO2
            // 
            this.uC_DADO2.Location = new System.Drawing.Point(157, 155);
            this.uC_DADO2.Name = "uC_DADO2";
            this.uC_DADO2.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO2.TabIndex = 4;
            // 
            // uC_DADO3
            // 
            this.uC_DADO3.Location = new System.Drawing.Point(313, 155);
            this.uC_DADO3.Name = "uC_DADO3";
            this.uC_DADO3.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO3.TabIndex = 5;
            // 
            // uC_DADO4
            // 
            this.uC_DADO4.Location = new System.Drawing.Point(469, 155);
            this.uC_DADO4.Name = "uC_DADO4";
            this.uC_DADO4.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO4.TabIndex = 6;
            // 
            // uC_DADO5
            // 
            this.uC_DADO5.Location = new System.Drawing.Point(625, 155);
            this.uC_DADO5.Name = "uC_DADO5";
            this.uC_DADO5.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 324);
            this.Controls.Add(this.uC_DADO5);
            this.Controls.Add(this.uC_DADO4);
            this.Controls.Add(this.uC_DADO3);
            this.Controls.Add(this.uC_DADO2);
            this.Controls.Add(this.uC_DADO1);
            this.Controls.Add(this.btn_validarIngresos);
            this.Controls.Add(this.uC_INGRESOS2);
            this.Controls.Add(this.uC_INGRESOS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_INGRESOS uC_INGRESOS1;
        private UC_INGRESOS uC_INGRESOS2;
        private System.Windows.Forms.Button btn_validarIngresos;
        private UC_DADO uC_DADO1;
        private UC_DADO uC_DADO2;
        private UC_DADO uC_DADO3;
        private UC_DADO uC_DADO4;
        private UC_DADO uC_DADO5;
    }
}


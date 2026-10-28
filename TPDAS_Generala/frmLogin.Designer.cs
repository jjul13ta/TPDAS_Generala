namespace TPDAS_Generala
{
    partial class frmLogin
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
            this.uC_INGRESOS1 = new TPDAS_Generala.UC_INGRESOS();
            this.uC_INGRESOS2 = new TPDAS_Generala.UC_INGRESOS();
            this.uC_INGRESOS3 = new TPDAS_Generala.UC_INGRESOS();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_INGRESOS1
            // 
            this.uC_INGRESOS1.Etiqueta = "label1";
            this.uC_INGRESOS1.Location = new System.Drawing.Point(185, 88);
            this.uC_INGRESOS1.Name = "uC_INGRESOS1";
            this.uC_INGRESOS1.Requerido = false;
            this.uC_INGRESOS1.Size = new System.Drawing.Size(8, 8);
            this.uC_INGRESOS1.TabIndex = 0;
            this.uC_INGRESOS1.Texto = "";
            // 
            // uC_INGRESOS2
            // 
            this.uC_INGRESOS2.Etiqueta = "label1";
            this.uC_INGRESOS2.Location = new System.Drawing.Point(0, 1);
            this.uC_INGRESOS2.Name = "uC_INGRESOS2";
            this.uC_INGRESOS2.Requerido = false;
            this.uC_INGRESOS2.Size = new System.Drawing.Size(273, 71);
            this.uC_INGRESOS2.TabIndex = 1;
            this.uC_INGRESOS2.Texto = "";
            // 
            // uC_INGRESOS3
            // 
            this.uC_INGRESOS3.Etiqueta = "label1";
            this.uC_INGRESOS3.Location = new System.Drawing.Point(0, 65);
            this.uC_INGRESOS3.Name = "uC_INGRESOS3";
            this.uC_INGRESOS3.Requerido = false;
            this.uC_INGRESOS3.Size = new System.Drawing.Size(273, 71);
            this.uC_INGRESOS3.TabIndex = 2;
            this.uC_INGRESOS3.Texto = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_INGRESOS3);
            this.Controls.Add(this.uC_INGRESOS2);
            this.Controls.Add(this.uC_INGRESOS1);
            this.Name = "frmLogin";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_INGRESOS uC_INGRESOS1;
        private UC_INGRESOS uC_INGRESOS2;
        private UC_INGRESOS uC_INGRESOS3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
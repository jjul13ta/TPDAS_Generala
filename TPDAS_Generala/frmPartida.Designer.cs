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
            this.uC_DADO1 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO2 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO3 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO4 = new TPDAS_Generala.UC_DADO();
            this.uC_DADO5 = new TPDAS_Generala.UC_DADO();
            this.SuspendLayout();
            // 
            // uC_DADO1
            // 
            this.uC_DADO1.Location = new System.Drawing.Point(0, 301);
            this.uC_DADO1.Name = "uC_DADO1";
            this.uC_DADO1.Numero = 0;
            this.uC_DADO1.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO1.TabIndex = 0;
            // 
            // uC_DADO2
            // 
            this.uC_DADO2.Location = new System.Drawing.Point(171, 301);
            this.uC_DADO2.Name = "uC_DADO2";
            this.uC_DADO2.Numero = 0;
            this.uC_DADO2.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO2.TabIndex = 1;
            // 
            // uC_DADO3
            // 
            this.uC_DADO3.Location = new System.Drawing.Point(340, 301);
            this.uC_DADO3.Name = "uC_DADO3";
            this.uC_DADO3.Numero = 0;
            this.uC_DADO3.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO3.TabIndex = 2;
            // 
            // uC_DADO4
            // 
            this.uC_DADO4.Location = new System.Drawing.Point(496, 301);
            this.uC_DADO4.Name = "uC_DADO4";
            this.uC_DADO4.Numero = 0;
            this.uC_DADO4.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO4.TabIndex = 3;
            // 
            // uC_DADO5
            // 
            this.uC_DADO5.Location = new System.Drawing.Point(652, 301);
            this.uC_DADO5.Name = "uC_DADO5";
            this.uC_DADO5.Numero = 0;
            this.uC_DADO5.Size = new System.Drawing.Size(150, 150);
            this.uC_DADO5.TabIndex = 4;
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_DADO5);
            this.Controls.Add(this.uC_DADO4);
            this.Controls.Add(this.uC_DADO3);
            this.Controls.Add(this.uC_DADO2);
            this.Controls.Add(this.uC_DADO1);
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_DADO uC_DADO1;
        private UC_DADO uC_DADO2;
        private UC_DADO uC_DADO3;
        private UC_DADO uC_DADO4;
        private UC_DADO uC_DADO5;
    }
}
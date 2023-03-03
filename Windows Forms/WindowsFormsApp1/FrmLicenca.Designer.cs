namespace WindowsFormsApp1
{
    partial class FrmLicenca
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
            this.btnObLicenca = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnObLicenca
            // 
            this.btnObLicenca.Location = new System.Drawing.Point(27, 40);
            this.btnObLicenca.Name = "btnObLicenca";
            this.btnObLicenca.Size = new System.Drawing.Size(163, 28);
            this.btnObLicenca.TabIndex = 0;
            this.btnObLicenca.Text = "Obter Licença";
            this.btnObLicenca.UseVisualStyleBackColor = true;
            this.btnObLicenca.Click += new System.EventHandler(this.btnObLicenca_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(605, 98);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(27, 100);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(557, 20);
            this.txtChave.TabIndex = 2;
            this.txtChave.Text = "Chave de acesso";
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnObLicenca);
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObLicenca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtChave;
    }
}
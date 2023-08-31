namespace Classes___Aula01
{
    partial class Form1
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnCalculaVolume = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(211, 158);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 23);
            this.txtLado.TabIndex = 0;
            // 
            // btnCalculaVolume
            // 
            this.btnCalculaVolume.Location = new System.Drawing.Point(211, 201);
            this.btnCalculaVolume.Name = "btnCalculaVolume";
            this.btnCalculaVolume.Size = new System.Drawing.Size(107, 39);
            this.btnCalculaVolume.TabIndex = 1;
            this.btnCalculaVolume.Text = "Calcular o volume";
            this.btnCalculaVolume.UseVisualStyleBackColor = true;
            this.btnCalculaVolume.Click += new System.EventHandler(this.btnCalculaVolume_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(445, 180);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(38, 15);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 794);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnCalculaVolume);
            this.Controls.Add(this.txtLado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLado;
        private Button btnCalculaVolume;
        private Label lblVolume;
    }
}
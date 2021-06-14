
namespace IsteaTVInternetCompany
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.AtrasLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.CambiarClaveButton = new System.Windows.Forms.Button();
            this.CambiarPreguntaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione una opcion";
            // 
            // AtrasLinkLabel
            // 
            this.AtrasLinkLabel.AutoSize = true;
            this.AtrasLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtrasLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.AtrasLinkLabel.Location = new System.Drawing.Point(301, 21);
            this.AtrasLinkLabel.Name = "AtrasLinkLabel";
            this.AtrasLinkLabel.Size = new System.Drawing.Size(34, 15);
            this.AtrasLinkLabel.TabIndex = 3;
            this.AtrasLinkLabel.TabStop = true;
            this.AtrasLinkLabel.Text = "Atras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mi cuenta";
            // 
            // CambiarClaveButton
            // 
            this.CambiarClaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CambiarClaveButton.Location = new System.Drawing.Point(27, 113);
            this.CambiarClaveButton.Name = "CambiarClaveButton";
            this.CambiarClaveButton.Size = new System.Drawing.Size(293, 55);
            this.CambiarClaveButton.TabIndex = 5;
            this.CambiarClaveButton.Text = "Cambiar la clave";
            this.CambiarClaveButton.UseVisualStyleBackColor = true;
            // 
            // CambiarPreguntaButton
            // 
            this.CambiarPreguntaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CambiarPreguntaButton.Location = new System.Drawing.Point(27, 195);
            this.CambiarPreguntaButton.Name = "CambiarPreguntaButton";
            this.CambiarPreguntaButton.Size = new System.Drawing.Size(293, 55);
            this.CambiarPreguntaButton.TabIndex = 6;
            this.CambiarPreguntaButton.Text = "Cambiar Pregunta Secreta";
            this.CambiarPreguntaButton.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(358, 300);
            this.Controls.Add(this.CambiarPreguntaButton);
            this.Controls.Add(this.CambiarClaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AtrasLinkLabel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Mi Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel AtrasLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CambiarClabeButton;
        private System.Windows.Forms.Button PreguntaButton;
        private System.Windows.Forms.Button CambiarClaveButton;
        private System.Windows.Forms.Button CambiarPreguntaButton;
    }
}
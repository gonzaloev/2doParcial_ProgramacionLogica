
namespace IsteaTVInternetCompany
{
    partial class CanalItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CanalLabel = new System.Windows.Forms.Label();
            this.VerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canal:";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(74, 10);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 16);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "label3";
            // 
            // CanalLabel
            // 
            this.CanalLabel.AutoSize = true;
            this.CanalLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CanalLabel.ForeColor = System.Drawing.Color.White;
            this.CanalLabel.Location = new System.Drawing.Point(73, 42);
            this.CanalLabel.Name = "CanalLabel";
            this.CanalLabel.Size = new System.Drawing.Size(44, 16);
            this.CanalLabel.TabIndex = 3;
            this.CanalLabel.Text = "label4";
            // 
            // VerButton
            // 
            this.VerButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerButton.Location = new System.Drawing.Point(159, 10);
            this.VerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerButton.Name = "VerButton";
            this.VerButton.Size = new System.Drawing.Size(82, 22);
            this.VerButton.TabIndex = 4;
            this.VerButton.Text = "Ver";
            this.VerButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NombreLabel);
            this.panel1.Controls.Add(this.VerButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CanalLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 72);
            this.panel1.TabIndex = 5;
            // 
            // CanalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CanalItem";
            this.Size = new System.Drawing.Size(290, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CanalLabel;
        private System.Windows.Forms.Button VerButton;
        private System.Windows.Forms.Panel panel1;
    }
}

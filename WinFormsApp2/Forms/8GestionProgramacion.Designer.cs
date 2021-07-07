
namespace IsteaTVInternetCompany
{
    partial class GestionProgramacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarCanalesBox = new System.Windows.Forms.TextBox();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.listaDeCanalesControl1 = new IsteaTVInternetCompany.ListaDeCanalesControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // buscarCanalesBox
            // 
            this.buscarCanalesBox.Location = new System.Drawing.Point(68, 52);
            this.buscarCanalesBox.Name = "buscarCanalesBox";
            this.buscarCanalesBox.Size = new System.Drawing.Size(227, 23);
            this.buscarCanalesBox.TabIndex = 3;
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nuevoBtn.Location = new System.Drawing.Point(303, 52);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(75, 23);
            this.nuevoBtn.TabIndex = 4;
            this.nuevoBtn.Text = "Nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = true;
            // 
            // listaDeCanalesControl1
            // 
            this.listaDeCanalesControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDeCanalesControl1.Location = new System.Drawing.Point(11, 89);
            this.listaDeCanalesControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaDeCanalesControl1.Name = "listaDeCanalesControl1";
            this.listaDeCanalesControl1.Size = new System.Drawing.Size(367, 328);
            this.listaDeCanalesControl1.TabIndex = 5;
            // 
            // GestionProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(390, 435);
            this.Controls.Add(this.listaDeCanalesControl1);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.buscarCanalesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GestionProgramacion";
            this.Text = "Gestion de Programación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscarCanalesBox;
        private System.Windows.Forms.Button nuevoBtn;
        private ListaDeCanalesControl listaDeCanalesControl1;
    }
}
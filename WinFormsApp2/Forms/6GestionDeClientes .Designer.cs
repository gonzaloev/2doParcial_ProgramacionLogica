
namespace IsteaTVInternetCompany
{
    partial class Form5
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
            this.buscarBox = new System.Windows.Forms.TextBox();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.listaDeTitularesControlcs1 = new IsteaTVInternetCompany.ListaDeTitularesControlcs();
            this.BotonCSVClientes = new System.Windows.Forms.Button();
            this.SaveClientes = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // buscarBox
            // 
            this.buscarBox.Location = new System.Drawing.Point(73, 79);
            this.buscarBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarBox.Name = "buscarBox";
            this.buscarBox.Size = new System.Drawing.Size(302, 27);
            this.buscarBox.TabIndex = 2;
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nuevoBtn.Location = new System.Drawing.Point(499, 77);
            this.nuevoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(86, 31);
            this.nuevoBtn.TabIndex = 3;
            this.nuevoBtn.Text = "Nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = true;
            // 
            // listaDeTitularesControlcs1
            // 
            this.listaDeTitularesControlcs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listaDeTitularesControlcs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDeTitularesControlcs1.Location = new System.Drawing.Point(15, 123);
            this.listaDeTitularesControlcs1.Name = "listaDeTitularesControlcs1";
            this.listaDeTitularesControlcs1.Size = new System.Drawing.Size(570, 333);
            this.listaDeTitularesControlcs1.TabIndex = 0;
            // 
            // BotonCSVClientes
            // 
            this.BotonCSVClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonCSVClientes.Location = new System.Drawing.Point(390, 77);
            this.BotonCSVClientes.Name = "BotonCSVClientes";
            this.BotonCSVClientes.Size = new System.Drawing.Size(94, 29);
            this.BotonCSVClientes.TabIndex = 4;
            this.BotonCSVClientes.Text = "Reporte";
            this.BotonCSVClientes.UseVisualStyleBackColor = true;
            // 
            // SaveClientes
            // 
            this.SaveClientes.Filter = "prueba|*.txt";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(599, 467);
            this.Controls.Add(this.BotonCSVClientes);
            this.Controls.Add(this.listaDeTitularesControlcs1);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.buscarBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Gestion de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscarBox;
        private System.Windows.Forms.Button nuevoBtn;
        private ListaDeTitularesControlcs listaDeTitularesControlcs1;
        private System.Windows.Forms.Button BotonCSVClientes;
        private System.Windows.Forms.SaveFileDialog SaveClientes;
    }
}
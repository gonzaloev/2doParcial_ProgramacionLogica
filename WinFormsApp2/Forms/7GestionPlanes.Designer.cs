
namespace IsteaTVInternetCompany
{
    partial class Form8
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
            this.buscarPlanesBox = new System.Windows.Forms.TextBox();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.listaDePlanes1 = new IsteaTVInternetCompany.ListaDePlanes();
            this.cargarCSVButton = new System.Windows.Forms.Button();
            this.openFilePlanes = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // buscarPlanesBox
            // 
            this.buscarPlanesBox.Location = new System.Drawing.Point(90, 59);
            this.buscarPlanesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarPlanesBox.Name = "buscarPlanesBox";
            this.buscarPlanesBox.Size = new System.Drawing.Size(277, 27);
            this.buscarPlanesBox.TabIndex = 2;
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nuevoBtn.Location = new System.Drawing.Point(386, 59);
            this.nuevoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(86, 31);
            this.nuevoBtn.TabIndex = 3;
            this.nuevoBtn.Text = "Nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = true;
            // 
            // listaDePlanes1
            // 
            this.listaDePlanes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listaDePlanes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDePlanes1.Location = new System.Drawing.Point(31, 97);
            this.listaDePlanes1.Name = "listaDePlanes1";
            this.listaDePlanes1.Size = new System.Drawing.Size(443, 431);
            this.listaDePlanes1.TabIndex = 4;
            // 
            // cargarCSVButton
            // 
            this.cargarCSVButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cargarCSVButton.Location = new System.Drawing.Point(386, 533);
            this.cargarCSVButton.Name = "cargarCSVButton";
            this.cargarCSVButton.Size = new System.Drawing.Size(94, 29);
            this.cargarCSVButton.TabIndex = 5;
            this.cargarCSVButton.Text = "Cargar CSV";
            this.cargarCSVButton.UseVisualStyleBackColor = true;
            // 
            // openFilePlanes
            // 
            this.openFilePlanes.FileName = "openFilePlanes";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(507, 574);
            this.Controls.Add(this.cargarCSVButton);
            this.Controls.Add(this.listaDePlanes1);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.buscarPlanesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.Text = "Gestion de Planes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscarPlanesBox;
        private System.Windows.Forms.Button nuevoBtn;
        private ListaDePlanes listaDePlanes1;
        private System.Windows.Forms.Button cargarCSVButton;
        private System.Windows.Forms.OpenFileDialog openFilePlanes;
    }
}
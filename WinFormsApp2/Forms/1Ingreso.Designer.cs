
namespace IsteaTVInternetCompany
{
    partial class Principal
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
            this.tvLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.claveLabel = new System.Windows.Forms.Label();
            this.claveBox = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.olvideClaveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.salirBtn = new System.Windows.Forms.Button();
            this.registrarseLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tvLabel
            // 
            this.tvLabel.AutoSize = true;
            this.tvLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tvLabel.ForeColor = System.Drawing.Color.White;
            this.tvLabel.Location = new System.Drawing.Point(4, 21);
            this.tvLabel.Name = "tvLabel";
            this.tvLabel.Size = new System.Drawing.Size(435, 100);
            this.tvLabel.TabIndex = 0;
            this.tvLabel.Text = "ISTEA \r\nTV && Internet Company";
            this.tvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuarioLabel.Location = new System.Drawing.Point(184, 138);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(50, 16);
            this.usuarioLabel.TabIndex = 1;
            this.usuarioLabel.Text = "Usuario";
            // 
            // usuarioBox
            // 
            this.usuarioBox.Location = new System.Drawing.Point(132, 157);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(156, 23);
            this.usuarioBox.TabIndex = 2;
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.claveLabel.ForeColor = System.Drawing.Color.White;
            this.claveLabel.Location = new System.Drawing.Point(188, 188);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(42, 16);
            this.claveLabel.TabIndex = 3;
            this.claveLabel.Text = "Clave";
            // 
            // claveBox
            // 
            this.claveBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.claveBox.Location = new System.Drawing.Point(132, 214);
            this.claveBox.Name = "claveBox";
            this.claveBox.Size = new System.Drawing.Size(156, 25);
            this.claveBox.TabIndex = 4;
            this.claveBox.TextChanged += new System.EventHandler(this.claveBox_TextChanged);
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingresarBtn.Location = new System.Drawing.Point(220, 353);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(92, 39);
            this.ingresarBtn.TabIndex = 5;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // olvideClaveLinkLabel
            // 
            this.olvideClaveLinkLabel.AutoSize = true;
            this.olvideClaveLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.olvideClaveLinkLabel.LinkColor = System.Drawing.Color.White;
            this.olvideClaveLinkLabel.Location = new System.Drawing.Point(164, 257);
            this.olvideClaveLinkLabel.Name = "olvideClaveLinkLabel";
            this.olvideClaveLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.olvideClaveLinkLabel.Size = new System.Drawing.Size(92, 15);
            this.olvideClaveLinkLabel.TabIndex = 6;
            this.olvideClaveLinkLabel.TabStop = true;
            this.olvideClaveLinkLabel.Text = "Olvide mi clave";
            this.olvideClaveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.olvideClaveLinkLabel_LinkClicked);
            // 
            // salirBtn
            // 
            this.salirBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salirBtn.Location = new System.Drawing.Point(110, 353);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(92, 39);
            this.salirBtn.TabIndex = 7;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // registrarseLink
            // 
            this.registrarseLink.AutoSize = true;
            this.registrarseLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrarseLink.LinkColor = System.Drawing.Color.White;
            this.registrarseLink.Location = new System.Drawing.Point(122, 294);
            this.registrarseLink.Name = "registrarseLink";
            this.registrarseLink.Size = new System.Drawing.Size(174, 15);
            this.registrarseLink.TabIndex = 8;
            this.registrarseLink.TabStop = true;
            this.registrarseLink.Text = "¿No tiene usuario? Registrarse";
            this.registrarseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registrarseLink_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(442, 429);
            this.Controls.Add(this.registrarseLink);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.olvideClaveLinkLabel);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.claveBox);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.usuarioBox);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.tvLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tvLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.TextBox claveBox;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.LinkLabel olvideClaveLinkLabel;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.LinkLabel registrarseLink;
    }
}


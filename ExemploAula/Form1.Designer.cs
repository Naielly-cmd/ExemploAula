namespace ExemploAula
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
            lbllogin = new Label();
            lblusuario = new Label();
            txtusuario = new TextBox();
            lblsenha = new Label();
            txtsenha = new TextBox();
            btnlogar = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            lbllogin.Location = new Point(348, 46);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(49, 20);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblusuario.Location = new Point(272, 105);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(65, 19);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            txtusuario.Location = new Point(443, 105);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 26);
            txtusuario.TabIndex = 2;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblsenha.Location = new Point(272, 196);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(56, 19);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha";
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            txtsenha.Location = new Point(443, 193);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 26);
            txtsenha.TabIndex = 4;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic);
            btnlogar.Location = new Point(348, 254);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(75, 29);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(lblsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private TextBox txtusuario;
        private Label lblsenha;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}

namespace Senac.Foods
{
    partial class FrmLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 552);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(394, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 552);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Black;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(131, 328);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(211, 62);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(82, 241);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(358, 42);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Black;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(76, 136);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(358, 42);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 241);
            label3.Name = "label3";
            label3.Size = new Size(410, 48);
            label3.TabIndex = 1;
            label3.Text = "__________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 136);
            label1.Name = "label1";
            label1.Size = new Size(410, 48);
            label1.TabIndex = 1;
            label1.Text = "__________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 213);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1006, 552);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "food ";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label1;
        private Label label3;
        private Button btnEntrar;
        private PictureBox pictureBox1;
    }
}

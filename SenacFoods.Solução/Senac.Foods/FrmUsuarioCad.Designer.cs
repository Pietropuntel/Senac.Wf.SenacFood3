namespace Senac.Foods
{
    partial class FrmUsuarioCad
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
            panel1 = new Panel();
            label1 = new Label();
            btnFechar = new Button();
            lblNomeDoUsuario = new Label();
            txtNomeDoUsuario = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            mtbPerfildoUsuario = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            txtConfirmacaoDeSenha = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 81);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 25);
            label1.Name = "label1";
            label1.Size = new Size(213, 24);
            label1.TabIndex = 5;
            label1.Text = "Cadrasto de Usuário";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Yellow;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1282, 19);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(38, 38);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblNomeDoUsuario
            // 
            lblNomeDoUsuario.AutoSize = true;
            lblNomeDoUsuario.BackColor = Color.Red;
            lblNomeDoUsuario.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeDoUsuario.Location = new Point(27, 142);
            lblNomeDoUsuario.Name = "lblNomeDoUsuario";
            lblNomeDoUsuario.Size = new Size(163, 24);
            lblNomeDoUsuario.TabIndex = 7;
            lblNomeDoUsuario.Text = "Nome do Usuário";
            // 
            // txtNomeDoUsuario
            // 
            txtNomeDoUsuario.Location = new Point(27, 169);
            txtNomeDoUsuario.Name = "txtNomeDoUsuario";
            txtNomeDoUsuario.Size = new Size(333, 31);
            txtNomeDoUsuario.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 203);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 9;
            label2.Text = "Email ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 31);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 264);
            label3.Name = "label3";
            label3.Size = new Size(71, 24);
            label3.TabIndex = 11;
            label3.Text = "Senha ";
            // 
            // txtSenha
            // 
            txtSenha.AcceptsReturn = true;
            txtSenha.Location = new Point(27, 291);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(333, 31);
            txtSenha.TabIndex = 12;
            // 
            // mtbPerfildoUsuario
            // 
            mtbPerfildoUsuario.Location = new Point(27, 413);
            mtbPerfildoUsuario.Name = "mtbPerfildoUsuario";
            mtbPerfildoUsuario.Size = new Size(333, 31);
            mtbPerfildoUsuario.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 386);
            label4.Name = "label4";
            label4.Size = new Size(156, 24);
            label4.TabIndex = 14;
            label4.Text = "Perfil do Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 325);
            label5.Name = "label5";
            label5.Size = new Size(216, 24);
            label5.TabIndex = 15;
            label5.Text = "Confirmação de Senha ";
            // 
            // txtConfirmacaoDeSenha
            // 
            txtConfirmacaoDeSenha.Location = new Point(27, 352);
            txtConfirmacaoDeSenha.Name = "txtConfirmacaoDeSenha";
            txtConfirmacaoDeSenha.Size = new Size(333, 31);
            txtConfirmacaoDeSenha.TabIndex = 16;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Yellow;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(722, 562);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 34);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Yellow;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(888, 562);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1078, 623);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtConfirmacaoDeSenha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mtbPerfildoUsuario);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNomeDoUsuario);
            Controls.Add(lblNomeDoUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioCad";
            Text = "FrmUsuarioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private Label lblNomeDoUsuario;
        private TextBox txtNomeDoUsuario;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSenha;
        private MaskedTextBox mtbPerfildoUsuario;
        private Label label4;
        private Label label5;
        private TextBox txtConfirmacaoDeSenha;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}
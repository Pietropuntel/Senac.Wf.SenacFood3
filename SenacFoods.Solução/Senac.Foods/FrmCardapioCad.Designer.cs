namespace Senac.Foods
{
    partial class FrmCardapioCad
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
            groupBox1 = new GroupBox();
            chkPossuiPreparo = new CheckBox();
            txtDescricao = new RichTextBox();
            txtPreco = new TextBox();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Location = new Point(-74, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 81);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 25);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 5;
            label1.Text = "Cadrasto de Cardapio";
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
            btnFechar.Click += btnFechar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Location = new Point(13, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 551);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPossuiPreparo.Location = new Point(38, 433);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(191, 36);
            chkPossuiPreparo.TabIndex = 9;
            chkPossuiPreparo.Text = "Possui Preparo ?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(38, 178);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(563, 96);
            txtDescricao.TabIndex = 8;
            txtDescricao.Text = "";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(38, 341);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(563, 31);
            txtPreco.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(38, 93);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(563, 31);
            txtTitulo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 302);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 5;
            label4.Text = "Preço";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 143);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 58);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 3;
            label2.Text = "Titulo";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Yellow;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(1031, 491);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(168, 44);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Yellow;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(863, 491);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 44);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1265, 695);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtTitulo;
        private TextBox txtPreco;
        private RichTextBox txtDescricao;
        private CheckBox chkPossuiPreparo;
    }
}
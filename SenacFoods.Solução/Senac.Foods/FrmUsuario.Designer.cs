namespace Senac.Foods
{
    partial class FrmUsuario
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
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnFechar = new Button();
            lblProcurar = new Label();
            txtProcurar = new TextBox();
            DgvUsuario = new DataGridView();
            btnEditar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Yellow;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(789, 590);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(907, 590);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Yellow;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1013, 51);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(38, 38);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblProcurar
            // 
            lblProcurar.AutoSize = true;
            lblProcurar.BackColor = Color.Yellow;
            lblProcurar.FlatStyle = FlatStyle.Flat;
            lblProcurar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcurar.Location = new Point(20, 34);
            lblProcurar.Name = "lblProcurar";
            lblProcurar.Size = new Size(84, 24);
            lblProcurar.TabIndex = 9;
            lblProcurar.Text = "Procurar";
            // 
            // txtProcurar
            // 
            txtProcurar.BackColor = Color.Yellow;
            txtProcurar.Location = new Point(127, 31);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(881, 31);
            txtProcurar.TabIndex = 8;
            // 
            // DgvUsuario
            // 
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuario.Location = new Point(51, 123);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.RowHeadersWidth = 62;
            DgvUsuario.Size = new Size(1000, 450);
            DgvUsuario.TabIndex = 7;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(671, 590);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblProcurar);
            panel1.Controls.Add(txtProcurar);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 91);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1126, 665);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(btnFechar);
            Controls.Add(DgvUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnFechar;
        private Label lblProcurar;
        private TextBox txtProcurar;
        private DataGridView DgvUsuario;
        private Button btnEditar;
        private Panel panel1;
    }
}
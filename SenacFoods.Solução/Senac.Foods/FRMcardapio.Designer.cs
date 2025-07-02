namespace Senac.Foods
{
    partial class FRMcardapio
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
            groupBox1 = new GroupBox();
            btnAdicionar = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtPesquisa = new TextBox();
            btnFechar = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(66, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 551);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Location = new Point(53, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(134, 40);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1031, 501);
            button2.Name = "button2";
            button2.Size = new Size(168, 32);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(863, 501);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Yellow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1155, 415);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(89, 33);
            label1.Name = "label1";
            label1.Size = new Size(95, 24);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.Yellow;
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Location = new Point(219, 32);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(690, 25);
            txtPesquisa.TabIndex = 2;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(txtPesquisa);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 81);
            panel1.TabIndex = 4;
            // 
            // FRMcardapio
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1352, 660);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRMcardapio";
            Text = "FRMcardapio";
            Load += FRMcardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private Button btnFechar;
        private Panel panel1;
    }
}
namespace Senac.Foods
{
    partial class FrmMesaCad
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
            label1 = new Label();
            btnFechar = new Button();
            groupBox1 = new GroupBox();
            txtNumeroMesa = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 7;
            label1.Text = "Cadrasto de Mesa";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Yellow;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1124, 24);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(38, 35);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtNumeroMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1174, 551);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(101, 140);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(157, 31);
            txtNumeroMesa.TabIndex = 6;
            txtNumeroMesa.TextChanged += txtNumeroMesa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 63);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 3;
            label2.Text = "Numero Mesa";
            label2.Click += label2_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Yellow;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Viner Hand ITC", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(983, 491);
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
            btnCancelar.Location = new Point(771, 491);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 44);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Yellow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(655, 352);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1198, 628);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFechar;
        private GroupBox groupBox1;
        private TextBox txtNumeroMesa;
        private Label label2;
        private Button btnSalvar;
        private Button btnCancelar;
        private DataGridView dataGridView1;
    }
}
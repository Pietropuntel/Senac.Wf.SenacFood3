namespace Senac.Foods
{
    partial class FrmPrincipal
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
            btnUsuario = new Button();
            btnPedidoCozinha = new Button();
            btnComanda = new Button();
            btnCardapios = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Yellow;
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapios);
            groupBox1.Location = new Point(97, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Red;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.Red;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.White;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.Location = new Point(621, 58);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(155, 129);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.Red;
            btnPedidoCozinha.FlatAppearance.BorderSize = 0;
            btnPedidoCozinha.FlatAppearance.MouseDownBackColor = Color.Red;
            btnPedidoCozinha.FlatAppearance.MouseOverBackColor = Color.White;
            btnPedidoCozinha.FlatStyle = FlatStyle.Flat;
            btnPedidoCozinha.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidoCozinha.Location = new Point(432, 58);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.Size = new Size(155, 129);
            btnPedidoCozinha.TabIndex = 0;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.UseVisualStyleBackColor = false;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Red;
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.FlatAppearance.MouseDownBackColor = Color.Red;
            btnComanda.FlatAppearance.MouseOverBackColor = Color.White;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.Location = new Point(252, 58);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(155, 129);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapios
            // 
            btnCardapios.BackColor = Color.Red;
            btnCardapios.FlatAppearance.BorderSize = 0;
            btnCardapios.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCardapios.FlatAppearance.MouseOverBackColor = Color.White;
            btnCardapios.FlatStyle = FlatStyle.Flat;
            btnCardapios.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardapios.Location = new Point(64, 58);
            btnCardapios.Name = "btnCardapios";
            btnCardapios.Size = new Size(155, 129);
            btnCardapios.TabIndex = 0;
            btnCardapios.Text = "Cardapio";
            btnCardapios.UseVisualStyleBackColor = false;
            btnCardapios.Click += btnCardapios_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Yellow;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(974, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(38, 38);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += button5_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Yellow;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(919, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(38, 38);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1041, 492);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUsuario;
        private Button btnPedidoCozinha;
        private Button btnComanda;
        private Button btnCardapios;
        private Button btnFechar;
        private Button btnMinimizar;
    }
}
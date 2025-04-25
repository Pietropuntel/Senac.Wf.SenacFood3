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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Red;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(97, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 58);
            button1.Name = "button1";
            button1.Size = new Size(155, 129);
            button1.TabIndex = 0;
            button1.Text = "Cardapio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(252, 58);
            button2.Name = "button2";
            button2.Size = new Size(155, 129);
            button2.TabIndex = 0;
            button2.Text = "Comanda";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(432, 58);
            button3.Name = "button3";
            button3.Size = new Size(155, 129);
            button3.TabIndex = 0;
            button3.Text = "Pedido Cozinha";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Red;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(621, 58);
            button4.Name = "button4";
            button4.Size = new Size(155, 129);
            button4.TabIndex = 0;
            button4.Text = "Usuário";
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1041, 492);
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
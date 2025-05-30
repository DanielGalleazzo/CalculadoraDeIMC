namespace CalculadoraDeIMCWF
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
            txtNome = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtIdade = new TextBox();
            lblNome = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            lblIdade = new Label();
            lblIMC = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(60, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(60, 303);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(180, 23);
            txtAltura.TabIndex = 1;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(60, 231);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(180, 23);
            txtPeso.TabIndex = 2;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(60, 155);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(180, 23);
            txtIdade.TabIndex = 3;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(491, 82);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 15);
            lblNome.TabIndex = 4;
            lblNome.Click += lblNome_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(491, 239);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(0, 15);
            lblAltura.TabIndex = 5;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(491, 191);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(0, 15);
            lblPeso.TabIndex = 6;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(491, 135);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(0, 15);
            lblIdade.TabIndex = 7;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Location = new Point(494, 284);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(0, 15);
            lblIMC.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(60, 353);
            button1.Name = "button1";
            button1.Size = new Size(180, 43);
            button1.TabIndex = 9;
            button1.Text = "Avançar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Insira o seu nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 11;
            textBox2.Text = "Insira a sua idade";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "Insira o seu peso";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(60, 281);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 13;
            textBox4.Text = "Insira a sua altura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(lblIMC);
            Controls.Add(lblIdade);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblNome);
            Controls.Add(txtIdade);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private TextBox txtIdade;
        private Label lblNome;
        private Label lblAltura;
        private Label lblPeso;
        private Label lblIdade;
        private Label lblIMC;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}

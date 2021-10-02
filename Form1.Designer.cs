
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnsoma = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnmultiplica = new System.Windows.Forms.Button();
            this.btndividi = new System.Windows.Forms.Button();
            this.btnsubtrai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(298, 44);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(83, 23);
            this.btnsoma.TabIndex = 7;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmultiplica
            // 
            this.btnmultiplica.Location = new System.Drawing.Point(298, 134);
            this.btnmultiplica.Name = "btnmultiplica";
            this.btnmultiplica.Size = new System.Drawing.Size(83, 23);
            this.btnmultiplica.TabIndex = 9;
            this.btnmultiplica.Text = "Multiplicação";
            this.btnmultiplica.UseVisualStyleBackColor = true;
            this.btnmultiplica.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndividi
            // 
            this.btndividi.Location = new System.Drawing.Point(298, 105);
            this.btndividi.Name = "btndividi";
            this.btndividi.Size = new System.Drawing.Size(83, 23);
            this.btndividi.TabIndex = 10;
            this.btndividi.Text = "Divisão";
            this.btndividi.UseVisualStyleBackColor = true;
            this.btndividi.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsubtrai
            // 
            this.btnsubtrai.Location = new System.Drawing.Point(298, 76);
            this.btnsubtrai.Name = "btnsubtrai";
            this.btnsubtrai.Size = new System.Drawing.Size(83, 23);
            this.btnsubtrai.TabIndex = 11;
            this.btnsubtrai.Text = "Subtração";
            this.btnsubtrai.UseVisualStyleBackColor = true;
            this.btnsubtrai.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 205);
            this.Controls.Add(this.btnsubtrai);
            this.Controls.Add(this.btndividi);
            this.Controls.Add(this.btnmultiplica);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnmultiplica;
        private System.Windows.Forms.Button btndividi;
        private System.Windows.Forms.Button btnsubtrai;
    }
}


namespace Aula06
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
            this.labelDigiteValorQuadrado = new System.Windows.Forms.Label();
            this.labelAreaQuadrado = new System.Windows.Forms.Label();
            this.labelPerimetroQuadrado = new System.Windows.Forms.Label();
            this.buttonQuadrado = new System.Windows.Forms.Button();
            this.textBoxLadoQuadrado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Triângulo = new System.Windows.Forms.GroupBox();
            this.labelAlturaTriangulo = new System.Windows.Forms.Label();
            this.textBoxAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.textBoxLadoTriangulo = new System.Windows.Forms.TextBox();
            this.buttonTriangulo = new System.Windows.Forms.Button();
            this.labelPerimetroTriangulo = new System.Windows.Forms.Label();
            this.labelAreaTriangulo = new System.Windows.Forms.Label();
            this.labelDigiteValorTriangulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxLadoRetangulo = new System.Windows.Forms.TextBox();
            this.buttonRetangulo = new System.Windows.Forms.Button();
            this.labelPerimetroRetangulo = new System.Windows.Forms.Label();
            this.labelAreaRetangulo = new System.Windows.Forms.Label();
            this.labelDigiteValorRetangulo = new System.Windows.Forms.Label();
            this.labelAlturaRetangulo = new System.Windows.Forms.Label();
            this.textBoxAlturaRetangulo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Triângulo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDigiteValorQuadrado
            // 
            this.labelDigiteValorQuadrado.AutoSize = true;
            this.labelDigiteValorQuadrado.Location = new System.Drawing.Point(8, 18);
            this.labelDigiteValorQuadrado.Name = "labelDigiteValorQuadrado";
            this.labelDigiteValorQuadrado.Size = new System.Drawing.Size(224, 13);
            this.labelDigiteValorQuadrado.TabIndex = 0;
            this.labelDigiteValorQuadrado.Text = "Digite o valor do lado do quadrado em metros:";
            // 
            // labelAreaQuadrado
            // 
            this.labelAreaQuadrado.AutoSize = true;
            this.labelAreaQuadrado.Location = new System.Drawing.Point(8, 102);
            this.labelAreaQuadrado.Name = "labelAreaQuadrado";
            this.labelAreaQuadrado.Size = new System.Drawing.Size(110, 13);
            this.labelAreaQuadrado.TabIndex = 1;
            this.labelAreaQuadrado.Text = "A área do quadrado é";
            // 
            // labelPerimetroQuadrado
            // 
            this.labelPerimetroQuadrado.AutoSize = true;
            this.labelPerimetroQuadrado.Location = new System.Drawing.Point(8, 124);
            this.labelPerimetroQuadrado.Name = "labelPerimetroQuadrado";
            this.labelPerimetroQuadrado.Size = new System.Drawing.Size(135, 13);
            this.labelPerimetroQuadrado.TabIndex = 2;
            this.labelPerimetroQuadrado.Text = "O perímetro do quadrado é";
            // 
            // buttonQuadrado
            // 
            this.buttonQuadrado.Location = new System.Drawing.Point(104, 59);
            this.buttonQuadrado.Name = "buttonQuadrado";
            this.buttonQuadrado.Size = new System.Drawing.Size(160, 23);
            this.buttonQuadrado.TabIndex = 3;
            this.buttonQuadrado.Text = "Calcular quadrado";
            this.buttonQuadrado.UseVisualStyleBackColor = true;
            this.buttonQuadrado.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxLadoQuadrado
            // 
            this.textBoxLadoQuadrado.Location = new System.Drawing.Point(238, 15);
            this.textBoxLadoQuadrado.Name = "textBoxLadoQuadrado";
            this.textBoxLadoQuadrado.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoQuadrado.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLadoQuadrado);
            this.groupBox1.Controls.Add(this.buttonQuadrado);
            this.groupBox1.Controls.Add(this.labelPerimetroQuadrado);
            this.groupBox1.Controls.Add(this.labelAreaQuadrado);
            this.groupBox1.Controls.Add(this.labelDigiteValorQuadrado);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quadrado";
            // 
            // Triângulo
            // 
            this.Triângulo.Controls.Add(this.labelAlturaTriangulo);
            this.Triângulo.Controls.Add(this.textBoxAlturaTriangulo);
            this.Triângulo.Controls.Add(this.textBoxLadoTriangulo);
            this.Triângulo.Controls.Add(this.buttonTriangulo);
            this.Triângulo.Controls.Add(this.labelPerimetroTriangulo);
            this.Triângulo.Controls.Add(this.labelAreaTriangulo);
            this.Triângulo.Controls.Add(this.labelDigiteValorTriangulo);
            this.Triângulo.Location = new System.Drawing.Point(16, 173);
            this.Triângulo.Name = "Triângulo";
            this.Triângulo.Size = new System.Drawing.Size(386, 164);
            this.Triângulo.TabIndex = 6;
            this.Triângulo.TabStop = false;
            this.Triângulo.Text = "Triângulo equilátero";
            // 
            // labelAlturaTriangulo
            // 
            this.labelAlturaTriangulo.AutoSize = true;
            this.labelAlturaTriangulo.Location = new System.Drawing.Point(8, 44);
            this.labelAlturaTriangulo.Name = "labelAlturaTriangulo";
            this.labelAlturaTriangulo.Size = new System.Drawing.Size(225, 13);
            this.labelAlturaTriangulo.TabIndex = 7;
            this.labelAlturaTriangulo.Text = "Digite o valor da altura do triângulo em metros:";
            // 
            // textBoxAlturaTriangulo
            // 
            this.textBoxAlturaTriangulo.Location = new System.Drawing.Point(238, 41);
            this.textBoxAlturaTriangulo.Name = "textBoxAlturaTriangulo";
            this.textBoxAlturaTriangulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlturaTriangulo.TabIndex = 5;
            // 
            // textBoxLadoTriangulo
            // 
            this.textBoxLadoTriangulo.Location = new System.Drawing.Point(238, 15);
            this.textBoxLadoTriangulo.Name = "textBoxLadoTriangulo";
            this.textBoxLadoTriangulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoTriangulo.TabIndex = 4;
            this.textBoxLadoTriangulo.TextChanged += new System.EventHandler(this.textBoxLadoTriangulo_TextChanged);
            // 
            // buttonTriangulo
            // 
            this.buttonTriangulo.Location = new System.Drawing.Point(104, 81);
            this.buttonTriangulo.Name = "buttonTriangulo";
            this.buttonTriangulo.Size = new System.Drawing.Size(160, 23);
            this.buttonTriangulo.TabIndex = 3;
            this.buttonTriangulo.Text = "Calcular triângulo";
            this.buttonTriangulo.UseVisualStyleBackColor = true;
            this.buttonTriangulo.Click += new System.EventHandler(this.buttonTriangulo_Click);
            // 
            // labelPerimetroTriangulo
            // 
            this.labelPerimetroTriangulo.AutoSize = true;
            this.labelPerimetroTriangulo.Location = new System.Drawing.Point(5, 134);
            this.labelPerimetroTriangulo.Name = "labelPerimetroTriangulo";
            this.labelPerimetroTriangulo.Size = new System.Drawing.Size(130, 13);
            this.labelPerimetroTriangulo.TabIndex = 2;
            this.labelPerimetroTriangulo.Text = "O perímetro do triângulo é";
            // 
            // labelAreaTriangulo
            // 
            this.labelAreaTriangulo.AutoSize = true;
            this.labelAreaTriangulo.Location = new System.Drawing.Point(6, 118);
            this.labelAreaTriangulo.Name = "labelAreaTriangulo";
            this.labelAreaTriangulo.Size = new System.Drawing.Size(105, 13);
            this.labelAreaTriangulo.TabIndex = 1;
            this.labelAreaTriangulo.Text = "A área do triângulo é";
            // 
            // labelDigiteValorTriangulo
            // 
            this.labelDigiteValorTriangulo.AutoSize = true;
            this.labelDigiteValorTriangulo.Location = new System.Drawing.Point(8, 18);
            this.labelDigiteValorTriangulo.Name = "labelDigiteValorTriangulo";
            this.labelDigiteValorTriangulo.Size = new System.Drawing.Size(219, 13);
            this.labelDigiteValorTriangulo.TabIndex = 0;
            this.labelDigiteValorTriangulo.Text = "Digite o valor do lado do triângulo em metros:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelAlturaRetangulo);
            this.groupBox3.Controls.Add(this.textBoxAlturaRetangulo);
            this.groupBox3.Controls.Add(this.textBoxLadoRetangulo);
            this.groupBox3.Controls.Add(this.buttonRetangulo);
            this.groupBox3.Controls.Add(this.labelPerimetroRetangulo);
            this.groupBox3.Controls.Add(this.labelAreaRetangulo);
            this.groupBox3.Controls.Add(this.labelDigiteValorRetangulo);
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 144);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retângulo";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxLadoRetangulo
            // 
            this.textBoxLadoRetangulo.Location = new System.Drawing.Point(238, 15);
            this.textBoxLadoRetangulo.Name = "textBoxLadoRetangulo";
            this.textBoxLadoRetangulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLadoRetangulo.TabIndex = 4;
            // 
            // buttonRetangulo
            // 
            this.buttonRetangulo.Location = new System.Drawing.Point(108, 66);
            this.buttonRetangulo.Name = "buttonRetangulo";
            this.buttonRetangulo.Size = new System.Drawing.Size(160, 23);
            this.buttonRetangulo.TabIndex = 3;
            this.buttonRetangulo.Text = "Calcular retângulo";
            this.buttonRetangulo.UseVisualStyleBackColor = true;
            this.buttonRetangulo.Click += new System.EventHandler(this.buttonRetangulo_Click);
            // 
            // labelPerimetroRetangulo
            // 
            this.labelPerimetroRetangulo.AutoSize = true;
            this.labelPerimetroRetangulo.Location = new System.Drawing.Point(6, 119);
            this.labelPerimetroRetangulo.Name = "labelPerimetroRetangulo";
            this.labelPerimetroRetangulo.Size = new System.Drawing.Size(134, 13);
            this.labelPerimetroRetangulo.TabIndex = 2;
            this.labelPerimetroRetangulo.Text = "O perímetro do retângulo é";
            // 
            // labelAreaRetangulo
            // 
            this.labelAreaRetangulo.AutoSize = true;
            this.labelAreaRetangulo.Location = new System.Drawing.Point(8, 102);
            this.labelAreaRetangulo.Name = "labelAreaRetangulo";
            this.labelAreaRetangulo.Size = new System.Drawing.Size(109, 13);
            this.labelAreaRetangulo.TabIndex = 1;
            this.labelAreaRetangulo.Text = "A área do retângulo é";
            // 
            // labelDigiteValorRetangulo
            // 
            this.labelDigiteValorRetangulo.AutoSize = true;
            this.labelDigiteValorRetangulo.Location = new System.Drawing.Point(8, 18);
            this.labelDigiteValorRetangulo.Name = "labelDigiteValorRetangulo";
            this.labelDigiteValorRetangulo.Size = new System.Drawing.Size(223, 13);
            this.labelDigiteValorRetangulo.TabIndex = 0;
            this.labelDigiteValorRetangulo.Text = "Digite o valor do lado do retângulo em metros:";
            // 
            // labelAlturaRetangulo
            // 
            this.labelAlturaRetangulo.AutoSize = true;
            this.labelAlturaRetangulo.Location = new System.Drawing.Point(8, 43);
            this.labelAlturaRetangulo.Name = "labelAlturaRetangulo";
            this.labelAlturaRetangulo.Size = new System.Drawing.Size(229, 13);
            this.labelAlturaRetangulo.TabIndex = 9;
            this.labelAlturaRetangulo.Text = "Digite o valor da altura do retângulo em metros:";
            // 
            // textBoxAlturaRetangulo
            // 
            this.textBoxAlturaRetangulo.Location = new System.Drawing.Point(238, 40);
            this.textBoxAlturaRetangulo.Name = "textBoxAlturaRetangulo";
            this.textBoxAlturaRetangulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlturaRetangulo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Triângulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Triângulo.ResumeLayout(false);
            this.Triângulo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDigiteValorQuadrado;
        private System.Windows.Forms.Label labelAreaQuadrado;
        private System.Windows.Forms.Label labelPerimetroQuadrado;
        private System.Windows.Forms.Button buttonQuadrado;
        private System.Windows.Forms.TextBox textBoxLadoQuadrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Triângulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxLadoRetangulo;
        private System.Windows.Forms.Button buttonRetangulo;
        private System.Windows.Forms.Label labelPerimetroRetangulo;
        private System.Windows.Forms.Label labelAreaRetangulo;
        private System.Windows.Forms.Label labelDigiteValorRetangulo;
        private System.Windows.Forms.TextBox textBoxLadoTriangulo;
        private System.Windows.Forms.Button buttonTriangulo;
        private System.Windows.Forms.Label labelPerimetroTriangulo;
        private System.Windows.Forms.Label labelAreaTriangulo;
        private System.Windows.Forms.Label labelDigiteValorTriangulo;
        private System.Windows.Forms.Label labelAlturaTriangulo;
        private System.Windows.Forms.TextBox textBoxAlturaTriangulo;
        private System.Windows.Forms.Label labelAlturaRetangulo;
        private System.Windows.Forms.TextBox textBoxAlturaRetangulo;
    }
}


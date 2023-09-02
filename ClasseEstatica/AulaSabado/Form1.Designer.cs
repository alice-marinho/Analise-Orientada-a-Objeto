namespace AulaSabado
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
            this.labelQuadradoResult = new System.Windows.Forms.Label();
            this.labelDigiteBaseCalcular = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelExpoente = new System.Windows.Forms.Label();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.buttonCalcularQuadrado = new System.Windows.Forms.Button();
            this.buttonCalcularPotencia = new System.Windows.Forms.Button();
            this.textBoxQuadrado = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxExpoente = new System.Windows.Forms.TextBox();
            this.groupBoxMatematica = new System.Windows.Forms.GroupBox();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelConverter = new System.Windows.Forms.Label();
            this.buttonFahrenheit = new System.Windows.Forms.Button();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.groupBoxDesafio1 = new System.Windows.Forms.GroupBox();
            this.btCelsius = new System.Windows.Forms.Button();
            this.labelConvertido = new System.Windows.Forms.Label();
            this.labelValores = new System.Windows.Forms.Label();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubstracao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatematica.SuspendLayout();
            this.groupBoxDesafio1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDigiteValorQuadrado
            // 
            this.labelDigiteValorQuadrado.AutoSize = true;
            this.labelDigiteValorQuadrado.Location = new System.Drawing.Point(13, 22);
            this.labelDigiteValorQuadrado.Name = "labelDigiteValorQuadrado";
            this.labelDigiteValorQuadrado.Size = new System.Drawing.Size(198, 13);
            this.labelDigiteValorQuadrado.TabIndex = 0;
            this.labelDigiteValorQuadrado.Text = "Digite um valor para calcular o quadrado";
            // 
            // labelQuadradoResult
            // 
            this.labelQuadradoResult.AutoSize = true;
            this.labelQuadradoResult.Location = new System.Drawing.Point(149, 59);
            this.labelQuadradoResult.Name = "labelQuadradoResult";
            this.labelQuadradoResult.Size = new System.Drawing.Size(57, 13);
            this.labelQuadradoResult.TabIndex = 1;
            this.labelQuadradoResult.Text = "Quadrado:";
            // 
            // labelDigiteBaseCalcular
            // 
            this.labelDigiteBaseCalcular.AutoSize = true;
            this.labelDigiteBaseCalcular.Location = new System.Drawing.Point(13, 97);
            this.labelDigiteBaseCalcular.Name = "labelDigiteBaseCalcular";
            this.labelDigiteBaseCalcular.Size = new System.Drawing.Size(245, 13);
            this.labelDigiteBaseCalcular.TabIndex = 2;
            this.labelDigiteBaseCalcular.Text = "Digite a base e o exponte para calcular a potencia";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(13, 131);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(34, 13);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "Base:";
            // 
            // labelExpoente
            // 
            this.labelExpoente.AutoSize = true;
            this.labelExpoente.Location = new System.Drawing.Point(13, 161);
            this.labelExpoente.Name = "labelExpoente";
            this.labelExpoente.Size = new System.Drawing.Size(55, 13);
            this.labelExpoente.TabIndex = 4;
            this.labelExpoente.Text = "Expoente:";
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Location = new System.Drawing.Point(154, 192);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(52, 13);
            this.labelPotencia.TabIndex = 5;
            this.labelPotencia.Text = "Potência:";
            // 
            // buttonCalcularQuadrado
            // 
            this.buttonCalcularQuadrado.Location = new System.Drawing.Point(16, 54);
            this.buttonCalcularQuadrado.Name = "buttonCalcularQuadrado";
            this.buttonCalcularQuadrado.Size = new System.Drawing.Size(122, 23);
            this.buttonCalcularQuadrado.TabIndex = 6;
            this.buttonCalcularQuadrado.Text = "Calcular quadrado";
            this.buttonCalcularQuadrado.UseVisualStyleBackColor = true;
            this.buttonCalcularQuadrado.Click += new System.EventHandler(this.buttonCalcularQuadrado_Click);
            // 
            // buttonCalcularPotencia
            // 
            this.buttonCalcularPotencia.Location = new System.Drawing.Point(16, 187);
            this.buttonCalcularPotencia.Name = "buttonCalcularPotencia";
            this.buttonCalcularPotencia.Size = new System.Drawing.Size(122, 23);
            this.buttonCalcularPotencia.TabIndex = 7;
            this.buttonCalcularPotencia.Text = "Calcular potência";
            this.buttonCalcularPotencia.UseVisualStyleBackColor = true;
            this.buttonCalcularPotencia.Click += new System.EventHandler(this.buttonCalcularPotencia_Click);
            // 
            // textBoxQuadrado
            // 
            this.textBoxQuadrado.Location = new System.Drawing.Point(217, 19);
            this.textBoxQuadrado.Name = "textBoxQuadrado";
            this.textBoxQuadrado.Size = new System.Drawing.Size(41, 20);
            this.textBoxQuadrado.TabIndex = 8;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(74, 128);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(64, 20);
            this.textBoxBase.TabIndex = 9;
            // 
            // textBoxExpoente
            // 
            this.textBoxExpoente.Location = new System.Drawing.Point(74, 158);
            this.textBoxExpoente.Name = "textBoxExpoente";
            this.textBoxExpoente.Size = new System.Drawing.Size(64, 20);
            this.textBoxExpoente.TabIndex = 11;
            // 
            // groupBoxMatematica
            // 
            this.groupBoxMatematica.Controls.Add(this.textBoxExpoente);
            this.groupBoxMatematica.Controls.Add(this.textBoxBase);
            this.groupBoxMatematica.Controls.Add(this.textBoxQuadrado);
            this.groupBoxMatematica.Controls.Add(this.buttonCalcularPotencia);
            this.groupBoxMatematica.Controls.Add(this.buttonCalcularQuadrado);
            this.groupBoxMatematica.Controls.Add(this.labelPotencia);
            this.groupBoxMatematica.Controls.Add(this.labelExpoente);
            this.groupBoxMatematica.Controls.Add(this.labelBase);
            this.groupBoxMatematica.Controls.Add(this.labelDigiteBaseCalcular);
            this.groupBoxMatematica.Controls.Add(this.labelQuadradoResult);
            this.groupBoxMatematica.Controls.Add(this.labelDigiteValorQuadrado);
            this.groupBoxMatematica.Location = new System.Drawing.Point(11, 12);
            this.groupBoxMatematica.Name = "groupBoxMatematica";
            this.groupBoxMatematica.Size = new System.Drawing.Size(288, 227);
            this.groupBoxMatematica.TabIndex = 12;
            this.groupBoxMatematica.TabStop = false;
            this.groupBoxMatematica.Text = "Matemática";
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Location = new System.Drawing.Point(30, 23);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(70, 13);
            this.labelTemperatura.TabIndex = 13;
            this.labelTemperatura.Text = "Temperatura:";
            // 
            // labelConverter
            // 
            this.labelConverter.AutoSize = true;
            this.labelConverter.Location = new System.Drawing.Point(29, 48);
            this.labelConverter.Name = "labelConverter";
            this.labelConverter.Size = new System.Drawing.Size(73, 13);
            this.labelConverter.TabIndex = 14;
            this.labelConverter.Text = "Converter em:";
            // 
            // buttonFahrenheit
            // 
            this.buttonFahrenheit.Location = new System.Drawing.Point(28, 71);
            this.buttonFahrenheit.Name = "buttonFahrenheit";
            this.buttonFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.buttonFahrenheit.TabIndex = 15;
            this.buttonFahrenheit.Text = "Fahrenheit";
            this.buttonFahrenheit.UseVisualStyleBackColor = true;
            this.buttonFahrenheit.Click += new System.EventHandler(this.buttonFahrenheit_Click);
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(106, 19);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(72, 20);
            this.textBoxTemperatura.TabIndex = 16;
            // 
            // groupBoxDesafio1
            // 
            this.groupBoxDesafio1.Controls.Add(this.labelConvertido);
            this.groupBoxDesafio1.Controls.Add(this.btCelsius);
            this.groupBoxDesafio1.Controls.Add(this.textBoxTemperatura);
            this.groupBoxDesafio1.Controls.Add(this.buttonFahrenheit);
            this.groupBoxDesafio1.Controls.Add(this.labelConverter);
            this.groupBoxDesafio1.Controls.Add(this.labelTemperatura);
            this.groupBoxDesafio1.Location = new System.Drawing.Point(353, 12);
            this.groupBoxDesafio1.Name = "groupBoxDesafio1";
            this.groupBoxDesafio1.Size = new System.Drawing.Size(239, 126);
            this.groupBoxDesafio1.TabIndex = 17;
            this.groupBoxDesafio1.TabStop = false;
            this.groupBoxDesafio1.Text = "Desafio 1";
            // 
            // btCelsius
            // 
            this.btCelsius.Location = new System.Drawing.Point(132, 71);
            this.btCelsius.Name = "btCelsius";
            this.btCelsius.Size = new System.Drawing.Size(75, 23);
            this.btCelsius.TabIndex = 18;
            this.btCelsius.Text = "Celsius";
            this.btCelsius.UseVisualStyleBackColor = true;
            this.btCelsius.Click += new System.EventHandler(this.btCelsius_Click);
            // 
            // labelConvertido
            // 
            this.labelConvertido.AutoSize = true;
            this.labelConvertido.Location = new System.Drawing.Point(30, 105);
            this.labelConvertido.Name = "labelConvertido";
            this.labelConvertido.Size = new System.Drawing.Size(120, 13);
            this.labelConvertido.TabIndex = 19;
            this.labelConvertido.Text = "Temperatura convertida";
            // 
            // labelValores
            // 
            this.labelValores.AutoSize = true;
            this.labelValores.Location = new System.Drawing.Point(20, 19);
            this.labelValores.Name = "labelValores";
            this.labelValores.Size = new System.Drawing.Size(42, 13);
            this.labelValores.TabIndex = 18;
            this.labelValores.Text = "Valores";
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(103, 12);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(80, 23);
            this.buttonSoma.TabIndex = 20;
            this.buttonSoma.Text = "Soma";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubstracao
            // 
            this.buttonSubstracao.Location = new System.Drawing.Point(102, 37);
            this.buttonSubstracao.Name = "buttonSubstracao";
            this.buttonSubstracao.Size = new System.Drawing.Size(81, 23);
            this.buttonSubstracao.TabIndex = 21;
            this.buttonSubstracao.Text = "Subtração";
            this.buttonSubstracao.UseVisualStyleBackColor = true;
            this.buttonSubstracao.Click += new System.EventHandler(this.buttonSubstracao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Location = new System.Drawing.Point(103, 61);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(80, 23);
            this.buttonMultiplicacao.TabIndex = 22;
            this.buttonMultiplicacao.Text = "Multiplicação";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Location = new System.Drawing.Point(102, 86);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(81, 23);
            this.buttonDivisao.TabIndex = 23;
            this.buttonDivisao.Text = "Divisão";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(12, 39);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(62, 20);
            this.textBoxValor1.TabIndex = 24;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Location = new System.Drawing.Point(12, 63);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(62, 20);
            this.textBoxValor2.TabIndex = 25;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(9, 96);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(18, 13);
            this.labelResultado.TabIndex = 26;
            this.labelResultado.Text = "R:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelResultado);
            this.groupBox1.Controls.Add(this.textBoxValor2);
            this.groupBox1.Controls.Add(this.textBoxValor1);
            this.groupBox1.Controls.Add(this.buttonDivisao);
            this.groupBox1.Controls.Add(this.buttonMultiplicacao);
            this.groupBox1.Controls.Add(this.buttonSubstracao);
            this.groupBox1.Controls.Add(this.buttonSoma);
            this.groupBox1.Controls.Add(this.labelValores);
            this.groupBox1.Location = new System.Drawing.Point(353, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 130);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDesafio1);
            this.Controls.Add(this.groupBoxMatematica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMatematica.ResumeLayout(false);
            this.groupBoxMatematica.PerformLayout();
            this.groupBoxDesafio1.ResumeLayout(false);
            this.groupBoxDesafio1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDigiteValorQuadrado;
        private System.Windows.Forms.Label labelQuadradoResult;
        private System.Windows.Forms.Label labelDigiteBaseCalcular;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelExpoente;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.Button buttonCalcularQuadrado;
        private System.Windows.Forms.Button buttonCalcularPotencia;
        private System.Windows.Forms.TextBox textBoxQuadrado;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxExpoente;
        private System.Windows.Forms.GroupBox groupBoxMatematica;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Label labelConverter;
        private System.Windows.Forms.Button buttonFahrenheit;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.GroupBox groupBoxDesafio1;
        private System.Windows.Forms.Button btCelsius;
        private System.Windows.Forms.Label labelConvertido;
        private System.Windows.Forms.Label labelValores;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubstracao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


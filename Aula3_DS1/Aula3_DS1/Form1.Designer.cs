namespace Aula3_DS1
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(237, 113);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(82, 13);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Primeiro número";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(231, 164);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(88, 13);
            this.labelNumber2.TabIndex = 1;
            this.labelNumber2.Text = "Segundo número";
            // 
            // labelNumber3
            // 
            this.labelNumber3.AutoSize = true;
            this.labelNumber3.Location = new System.Drawing.Point(235, 215);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(84, 13);
            this.labelNumber3.TabIndex = 2;
            this.labelNumber3.Text = "Terceiro número";
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(325, 110);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxN1.TabIndex = 3;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(325, 161);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxN2.TabIndex = 4;
            // 
            // textBoxN3
            // 
            this.textBoxN3.Location = new System.Drawing.Point(325, 212);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 20);
            this.textBoxN3.TabIndex = 5;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(240, 267);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(185, 23);
            this.buttonSoma.TabIndex = 6;
            this.buttonSoma.Text = "Calcular soma dos quadrados";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(247, 314);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(178, 13);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Clique no botão para exibir resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.labelNumber3);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber3;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonSoma;
    }
}


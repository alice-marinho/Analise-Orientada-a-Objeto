namespace Aula3_DS2
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelAntecessor = new System.Windows.Forms.Label();
            this.labelSucessor = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(264, 150);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Número";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(329, 147);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 1;
            // 
            // labelAntecessor
            // 
            this.labelAntecessor.AutoSize = true;
            this.labelAntecessor.Location = new System.Drawing.Point(264, 240);
            this.labelAntecessor.Name = "labelAntecessor";
            this.labelAntecessor.Size = new System.Drawing.Size(60, 13);
            this.labelAntecessor.TabIndex = 2;
            this.labelAntecessor.Text = "Antecessor";
            // 
            // labelSucessor
            // 
            this.labelSucessor.AutoSize = true;
            this.labelSucessor.Location = new System.Drawing.Point(264, 268);
            this.labelSucessor.Name = "labelSucessor";
            this.labelSucessor.Size = new System.Drawing.Size(51, 13);
            this.labelSucessor.TabIndex = 3;
            this.labelSucessor.Text = "Sucessor";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(267, 197);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(162, 23);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular antecessor e sucessor";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelSucessor);
            this.Controls.Add(this.labelAntecessor);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelAntecessor;
        private System.Windows.Forms.Label labelSucessor;
        private System.Windows.Forms.Button buttonCalcular;
    }
}


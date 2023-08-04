namespace _33___Criptografia_de_dados
{
    partial class Form1
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
            this.buttonCriptografar = new System.Windows.Forms.Button();
            this.buttonComparar = new System.Windows.Forms.Button();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCriptografar
            // 
            this.buttonCriptografar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriptografar.Location = new System.Drawing.Point(58, 328);
            this.buttonCriptografar.Name = "buttonCriptografar";
            this.buttonCriptografar.Size = new System.Drawing.Size(246, 71);
            this.buttonCriptografar.TabIndex = 0;
            this.buttonCriptografar.Text = "Criptografar";
            this.buttonCriptografar.UseVisualStyleBackColor = true;
            this.buttonCriptografar.Click += new System.EventHandler(this.buttonCriptografar_Click);
            // 
            // buttonComparar
            // 
            this.buttonComparar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComparar.Location = new System.Drawing.Point(330, 328);
            this.buttonComparar.Name = "buttonComparar";
            this.buttonComparar.Size = new System.Drawing.Size(246, 71);
            this.buttonComparar.TabIndex = 1;
            this.buttonComparar.Text = "Comparar";
            this.buttonComparar.UseVisualStyleBackColor = true;
            this.buttonComparar.Click += new System.EventHandler(this.buttonComparar_Click);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntrada.Location = new System.Drawing.Point(41, 37);
            this.textBoxEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(550, 130);
            this.textBoxEntrada.TabIndex = 2;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaida.Location = new System.Drawing.Point(41, 175);
            this.textBoxSaida.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(550, 130);
            this.textBoxSaida.TabIndex = 3;
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(57, 446);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(518, 87);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 566);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxSaida);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.buttonComparar);
            this.Controls.Add(this.buttonCriptografar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCriptografar;
        private System.Windows.Forms.Button buttonComparar;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Label labelResultado;
    }
}


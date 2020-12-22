namespace wfaLISTAENCADEADA
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(93, 67);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "INSERE";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1Inserir);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(93, 130);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "REMOVE";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2Remover);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Location = new System.Drawing.Point(93, 194);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "MENOR";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3Menor);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(195, 69);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(52, 20);
            this.tb1.TabIndex = 6;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(195, 132);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(52, 20);
            this.tb2.TabIndex = 7;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(195, 196);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(52, 20);
            this.tb3.TabIndex = 8;
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Location = new System.Drawing.Point(93, 259);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 9;
            this.bt4.Text = "MAIOR";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4Maior);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Location = new System.Drawing.Point(54, 356);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 10;
            this.bt5.Text = "IMPRIMIR";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5Imprimir);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(195, 261);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(52, 20);
            this.tb4.TabIndex = 11;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(155, 358);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(249, 20);
            this.tb5.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(455, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lista Encadeada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


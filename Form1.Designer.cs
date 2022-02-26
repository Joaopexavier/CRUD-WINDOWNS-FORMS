
namespace registration
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
            this.btncad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbtef = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(123, 196);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(74, 23);
            this.btncad.TabIndex = 0;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número:";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(108, 45);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(100, 20);
            this.txbname.TabIndex = 3;
            // 
            // txbtef
            // 
            this.txbtef.Location = new System.Drawing.Point(108, 104);
            this.txbtef.Name = "txbtef";
            this.txbtef.Size = new System.Drawing.Size(100, 20);
            this.txbtef.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 433);
            this.Controls.Add(this.txbtef);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbtef;
    }
}


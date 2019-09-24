namespace PesoIdeal
{
    partial class frmCalculoDePessoal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Ideal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(92, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "00.00";
           
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbnFeminino);
            this.gbSexo.Controls.Add(this.rbnMasculino);
            this.gbSexo.Location = new System.Drawing.Point(10, 12);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(166, 54);
            this.gbSexo.TabIndex = 4;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Location = new System.Drawing.Point(99, 20);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbnFeminino.TabIndex = 1;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            this.rbnFeminino.CheckedChanged += new System.EventHandler(this.RbnMasculino_CheckedChanged);
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(7, 20);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.RbnMasculino_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // frmCalculoDePessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 155);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmCalculoDePessoal";
            this.Text = "Cálculo do Peso Ideal";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.TextBox textBox1;
    }
}


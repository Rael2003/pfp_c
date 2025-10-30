namespace pfp_c
{
    partial class ucAtribuicao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tbAtribuicao = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbAtribuicao).BeginInit();
            SuspendLayout();
            // 
            // tbAtribuicao
            // 
            tbAtribuicao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbAtribuicao.Location = new Point(5, 34);
            tbAtribuicao.Margin = new Padding(4, 3, 4, 3);
            tbAtribuicao.Name = "tbAtribuicao";
            tbAtribuicao.Size = new Size(818, 448);
            tbAtribuicao.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 5;
            label1.Text = "Atribuição";
            // 
            // ucAtribuicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbAtribuicao);
            Controls.Add(label1);
            Name = "ucAtribuicao";
            Size = new Size(826, 485);
            ((System.ComponentModel.ISupportInitialize)tbAtribuicao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbAtribuicao;
        private Label label1;
    }
}

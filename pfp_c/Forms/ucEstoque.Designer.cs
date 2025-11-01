namespace pfp_c
{
    partial class ucEstoque
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
            button1 = new Button();
            tbCadastro = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbCadastro).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(748, 20);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 5;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            tbCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCadastro.Location = new Point(17, 51);
            tbCadastro.Margin = new Padding(4, 3, 4, 3);
            tbCadastro.Name = "tbCadastro";
            tbCadastro.Size = new Size(818, 448);
            tbCadastro.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Estoque";
            // 
            // ucEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(tbCadastro);
            Controls.Add(label1);
            Name = "ucEstoque";
            Size = new Size(848, 515);
            ((System.ComponentModel.ISupportInitialize)tbCadastro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView tbCadastro;
        private Label label1;
    }
}

namespace pfp_c
{
    partial class ucRegistro
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
            ((System.ComponentModel.ISupportInitialize)tbCadastro).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(735, 5);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 4;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbCadastro
            // 
            tbCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCadastro.Location = new Point(4, 36);
            tbCadastro.Margin = new Padding(4, 3, 4, 3);
            tbCadastro.Name = "tbCadastro";
            tbCadastro.Size = new Size(818, 448);
            tbCadastro.TabIndex = 3;
            // 
            // ucRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(tbCadastro);
            Name = "ucRegistro";
            Size = new Size(829, 491);
            ((System.ComponentModel.ISupportInitialize)tbCadastro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView tbCadastro;
    }
}

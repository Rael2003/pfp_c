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
            components = new System.ComponentModel.Container();
            tbRegistro = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)tbRegistro).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbRegistro
            // 
            tbRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRegistro.ContextMenuStrip = contextMenuStrip1;
            tbRegistro.Location = new Point(4, 36);
            tbRegistro.Margin = new Padding(4, 3, 4, 3);
            tbRegistro.Name = "tbRegistro";
            tbRegistro.Size = new Size(818, 448);
            tbRegistro.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 6;
            label1.Text = "Registro";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(100, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // ucRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(tbRegistro);
            Name = "ucRegistro";
            Size = new Size(829, 491);
            ((System.ComponentModel.ISupportInitialize)tbRegistro).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tbRegistro;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
    }
}

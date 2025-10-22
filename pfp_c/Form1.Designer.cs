namespace pfp_c
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPrincipal = new Panel();
            panel1 = new Panel();
            btnEstoque = new Button();
            btnRegistro = new Button();
            btnAtribuicao = new Button();
            btnCadastro = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Location = new Point(189, 0);
            pnlPrincipal.Margin = new Padding(4, 3, 4, 3);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(651, 388);
            pnlPrincipal.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(48, 80, 58);
            panel1.Controls.Add(btnEstoque);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(btnAtribuicao);
            panel1.Controls.Add(btnCadastro);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 388);
            panel1.TabIndex = 2;
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(49, 197);
            btnEstoque.Margin = new Padding(4, 3, 4, 3);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(88, 27);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click_1;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(49, 164);
            btnRegistro.Margin = new Padding(4, 3, 4, 3);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(88, 27);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click_1;
            // 
            // btnAtribuicao
            // 
            btnAtribuicao.Location = new Point(49, 130);
            btnAtribuicao.Margin = new Padding(4, 3, 4, 3);
            btnAtribuicao.Name = "btnAtribuicao";
            btnAtribuicao.Size = new Size(88, 27);
            btnAtribuicao.TabIndex = 1;
            btnAtribuicao.Text = "Atribuição";
            btnAtribuicao.UseVisualStyleBackColor = true;
            btnAtribuicao.Click += btnAtribuicao_Click_1;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(49, 97);
            btnCadastro.Margin = new Padding(4, 3, 4, 3);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(88, 27);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 385);
            Controls.Add(pnlPrincipal);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel panel1;
        private Button btnEstoque;
        private Button btnRegistro;
        private Button btnAtribuicao;
        private Button btnCadastro;
    }
}

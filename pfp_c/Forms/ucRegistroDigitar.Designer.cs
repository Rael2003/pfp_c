namespace pfp_c.Forms
{
    partial class ucRegistroDigitar
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
            lblCliente = new Label();
            lblFuncionario = new Label();
            lblData = new Label();
            lblStatus = new Label();
            lblDias = new Label();
            tbEntrega = new DataGridView();
            tbMateriaPrima = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)tbEntrega).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbMateriaPrima).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(94, 38);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(94, 65);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(70, 15);
            lblFuncionario.TabIndex = 1;
            lblFuncionario.Text = "Funcionário";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(94, 117);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 3;
            lblData.Text = "Data";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(94, 90);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(94, 142);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 4;
            lblDias.Text = "Dias";
            // 
            // tbEntrega
            // 
            tbEntrega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbEntrega.Location = new Point(3, 164);
            tbEntrega.Name = "tbEntrega";
            tbEntrega.Size = new Size(875, 104);
            tbEntrega.TabIndex = 5;
            // 
            // tbMateriaPrima
            // 
            tbMateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbMateriaPrima.Location = new Point(3, 274);
            tbMateriaPrima.Name = "tbMateriaPrima";
            tbMateriaPrima.Size = new Size(875, 104);
            tbMateriaPrima.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(459, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ucRegistroDigitar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(tbMateriaPrima);
            Controls.Add(tbEntrega);
            Controls.Add(lblDias);
            Controls.Add(lblData);
            Controls.Add(lblStatus);
            Controls.Add(lblFuncionario);
            Controls.Add(lblCliente);
            Name = "ucRegistroDigitar";
            Size = new Size(887, 429);
            ((System.ComponentModel.ISupportInitialize)tbEntrega).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbMateriaPrima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblFuncionario;
        private Label lblData;
        private Label lblStatus;
        private Label lblDias;
        private DataGridView tbEntrega;
        private DataGridView tbMateriaPrima;
        private Button btnCancelar;
    }
}

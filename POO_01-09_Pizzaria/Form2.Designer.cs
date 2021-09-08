
namespace POO_01_09_Pizzaria
{
    partial class Form2
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
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAtualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToAddRows = false;
            this.dataClientes.AllowUserToDeleteRows = false;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnBtnExcluir,
            this.ColumnAtualizar});
            this.dataClientes.Location = new System.Drawing.Point(12, 12);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowTemplate.Height = 25;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(527, 256);
            this.dataClientes.TabIndex = 0;
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClientes_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID Cliente";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome Cliente";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone Cliente";
            this.ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnBtnExcluir
            // 
            this.ColumnBtnExcluir.HeaderText = "Excluir";
            this.ColumnBtnExcluir.Name = "ColumnBtnExcluir";
            this.ColumnBtnExcluir.Text = "Excluir";
            this.ColumnBtnExcluir.UseColumnTextForButtonValue = true;
            // 
            // ColumnAtualizar
            // 
            this.ColumnAtualizar.HeaderText = "Atualizar";
            this.ColumnAtualizar.Name = "ColumnAtualizar";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(273, 274);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(266, 23);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.Text = "Fazer pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(12, 274);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(255, 24);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Novo cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 310);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.dataClientes);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnExcluir;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAtualizar;
    }
}
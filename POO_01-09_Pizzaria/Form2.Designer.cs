
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
            this.ColumnBtnPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClientes
            // 
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnBtnExcluir,
            this.ColumnBtnPedido});
            this.dataClientes.Location = new System.Drawing.Point(166, 22);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowTemplate.Height = 25;
            this.dataClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClientes.Size = new System.Drawing.Size(545, 256);
            this.dataClientes.TabIndex = 0;
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnBtnExcluir_Click);
            this.dataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnBtnPedido_Click);
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
            // ColumnBtnPedido
            // 
            this.ColumnBtnPedido.HeaderText = "Pedido";
            this.ColumnBtnPedido.Name = "ColumnBtnPedido";
            this.ColumnBtnPedido.Text = "Novo Pedido";
            this.ColumnBtnPedido.UseColumnTextForButtonValue = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 447);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnExcluir;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnPedido;
    }
}
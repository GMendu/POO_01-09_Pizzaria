using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POO_01_09_Pizzaria
{
    public partial class Form2 : Form
    {
        public Form2(Cliente a)
        {
            InitializeComponent();
            dataClientes.Rows.Add(new object[] { a.IdCliente, a.Nome, a.Telefone });
        }

        private void ColumnBtnExcluir_Click(object sender, DataGridViewCellEventArgs e)
        {
            dataClientes.Rows.RemoveAt(e.RowIndex);
        }
        private void ColumnBtnPedido_Click(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}

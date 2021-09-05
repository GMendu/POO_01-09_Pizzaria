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



        private void btnPedido_Click(object sender, EventArgs e)
        {
            List<string> Clientela = new List<string>();

            foreach (DataGridViewRow item in dataClientes.Rows)
            {
                if(item.Cells[1].Value != null)
                    Clientela.Add(item.Cells[1].Value.ToString());
            }
            Form3 f3 = new Form3(Clientela);
            f3.Show();
            this.Hide();
        }

        private void ColumnBtnExcluir_Click(object sender, DataGridViewCellEventArgs e)
        {
               dataClientes.Rows.RemoveAt(e.RowIndex);
        
        }
    }
}

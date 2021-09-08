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


        // dataClientes.Rows.RemoveAt(e.RowIndex);

        //using (Form5 f5 = new Form5())
        //{
        //    if (f5.ShowDialog() == DialogResult.OK)
        //    {
        
        //    }
        // }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string ultimoid = "0";
            foreach (DataGridViewRow item in dataClientes.Rows)
            {
                if (item.Cells[0].Value != null)
                    ultimoid = item.Cells[0].Value.ToString();
            }
            using (Form4 f4 = new Form4(ultimoid))
            {
                if (f4.ShowDialog() == DialogResult.OK)
                {
                    
                    dataClientes.Rows.Add(new object[] { f4.Idezin, f4.Nominho, f4.Telefonim });
                }
            }
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataClientes.CurrentCell.ColumnIndex == 3 && dataClientes.CurrentCell.RowIndex != -1)
            {
                dataClientes.Rows.RemoveAt(dataClientes.CurrentCell.RowIndex);
            }
            else if (dataClientes.CurrentCell.ColumnIndex == 4 && dataClientes.CurrentCell.RowIndex != -1)
            {
                using (Form5 f5 = new Form5())
                {
                    if (f5.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }
    }
}

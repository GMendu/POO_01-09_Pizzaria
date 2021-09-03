using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_01_09_Pizzaria
{
    public partial class Form1 : Form
    {
        public int numero = 1;
        public Form1()
        {
            InitializeComponent();
            txtClienteNum.Text = numero.ToString();
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cliente a = new Cliente();
            a.IdCliente = int.Parse(txtClienteNum.Text);
            a.Nome = txtNomeC.Text;
            a.Telefone = txtTelCliente.Text;
            numero++;

            Form2 f2 = new Form2(a);
            f2.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POO_01_09_Pizzaria
{
    public partial class Form3 : Form
    {
        public Form3(List<string> Clientinhos)
        {
           
            InitializeComponent();
            foreach (string Cliente in Clientinhos)
                listClientes.Items.Add(Cliente) ;
            txtBroto.Text = "0";
            txtMedia.Text = "0";
            txtGrande.Text = "0";
            txtFamilia.Text = "0";
            txtDoce.Text = "0";
            txtRefri.Text = "0";
            txtLata.Text = "0";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string Cliente = listClientes.SelectedItem.ToString();
            double preco = (int.Parse(txtBroto.Text)*29.90) + (int.Parse(txtMedia.Text)*33.90) + (int.Parse(txtGrande.Text)*36.90) + (int.Parse(txtFamilia.Text)*41.90) + (int.Parse(txtDoce.Text)*31.90) + (int.Parse(txtRefri.Text)*9.90) + (int.Parse(txtLata.Text)*5.90) ;
            MessageBox.Show($"Cliente:{Cliente}\nPreço total: {preco}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POO_01_09_Pizzaria
{
    public partial class Form4 : Form
    {
        public Form4(string num)
        {
            InitializeComponent();
            txtClienteNum.Text = (int.Parse(num) + 1).ToString();

        }
        public string Idezin
        {
            get { return txtClienteNum.Text; }
        }
        public string Nominho
        {
            get { return txtNomeC.Text; }
        }

        public string Telefonim
        {
            get { return txtTelCliente.Text; }
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

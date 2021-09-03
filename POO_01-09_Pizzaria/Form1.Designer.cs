
namespace POO_01_09_Pizzaria
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
            this.labelNomeC = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.labelTelCliente = new System.Windows.Forms.Label();
            this.labelClienteNum = new System.Windows.Forms.Label();
            this.txtClienteNum = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeC
            // 
            this.labelNomeC.AutoSize = true;
            this.labelNomeC.Location = new System.Drawing.Point(38, 102);
            this.labelNomeC.Name = "labelNomeC";
            this.labelNomeC.Size = new System.Drawing.Size(97, 15);
            this.labelNomeC.TabIndex = 0;
            this.labelNomeC.Text = "Nome do Cliente";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(162, 99);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(100, 23);
            this.txtNomeC.TabIndex = 1;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(162, 145);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(100, 23);
            this.txtTelCliente.TabIndex = 3;
            // 
            // labelTelCliente
            // 
            this.labelTelCliente.AutoSize = true;
            this.labelTelCliente.Location = new System.Drawing.Point(38, 148);
            this.labelTelCliente.Name = "labelTelCliente";
            this.labelTelCliente.Size = new System.Drawing.Size(108, 15);
            this.labelTelCliente.TabIndex = 2;
            this.labelTelCliente.Text = "Telefone do Cliente";
            // 
            // labelClienteNum
            // 
            this.labelClienteNum.AutoSize = true;
            this.labelClienteNum.Location = new System.Drawing.Point(96, 48);
            this.labelClienteNum.Name = "labelClienteNum";
            this.labelClienteNum.Size = new System.Drawing.Size(59, 15);
            this.labelClienteNum.TabIndex = 4;
            this.labelClienteNum.Text = "Cliente nº";
            // 
            // txtClienteNum
            // 
            this.txtClienteNum.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteNum.Location = new System.Drawing.Point(162, 48);
            this.txtClienteNum.Name = "txtClienteNum";
            this.txtClienteNum.Size = new System.Drawing.Size(53, 23);
            this.txtClienteNum.TabIndex = 5;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(235, 202);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 248);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtClienteNum);
            this.Controls.Add(this.labelClienteNum);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.labelTelCliente);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.labelNomeC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Label labelTelCliente;
        private System.Windows.Forms.Label labelClienteNum;
        private System.Windows.Forms.TextBox txtClienteNum;
        private System.Windows.Forms.Button btnCadastro;
    }
}


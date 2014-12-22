using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetPamonha
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text==""||txtEmail.Text==""||mktCPF.Text==""||mktTelefone.Text==""){
                MessageBox.Show("Preencha os dados","Erro");
            }
            else{
                 String nome;
            String cpf;
            String email;
            String telefone;


            nome = txtNome.Text;
            cpf = mktCPF.Text;
            email = txtEmail.Text;
            telefone = mktTelefone.Text;

            Cliente cliente = new Cliente();

            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Email = email;
            cliente.Telefone = telefone;
            
            DAOCliente Daocliente = new DAOCliente();


            Daocliente.insereCliente(cliente);
            mktCPF.Clear();
            txtNome.Text = "";
            txtEmail.Text="";
            mktTelefone.Clear();
            this.Close();
            }
        }
    }
}

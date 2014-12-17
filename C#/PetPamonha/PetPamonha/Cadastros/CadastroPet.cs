using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PetPamonha
{
    public partial class CadastroPet : Form
    {
        public CadastroPet()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            String nome;
            String dataDeNascimento;
            String raca;
            String rga;
            String dono;



            nome = txtNome.Text;
            dataDeNascimento = mkdDatadeNascimento.Text;
            raca = txtRaca.Text;
            rga = mktRGA.Text;
            dono = cmbDono.Text;



            DAOPet pet = new DAOPet();

            pet.inserePet(nome, dataDeNascimento, raca, rga, dono);







        }



        private void CadastroPet_Load(object sender, EventArgs e)
        
        // No form "CadastroPet" há uma combobox que pede "Dono" do pet. Neste caso acho todos os "nomes" de Clientes cadastrados e preencho na combobox atraves dos métodos do "comboBox";    
        {

            DAOCliente daoCliente = new DAOCliente();



            for(int i = 0; i < daoCliente.clientes.Count; i++){

            cmbDono.Items.Add(daoCliente.clientes[i].Nome);

            }




         }
           
            

            




        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        




        }
    }
}

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
        {


            


            /* 
             
             for (int i = 0; i < cliente.getClientes().Count; i++){
            
             cmbDono.Itens.add(cliente.getClientes().***);
             
            {
   
                 Muitas duvidas...
             * 
             * Mostrar o nome dos clientes na comboBox...
             * usar um arrayList de "cliente" ArrayList<cliente>
             * 
             * 

            }
           
            */

            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        




        }
    }
}

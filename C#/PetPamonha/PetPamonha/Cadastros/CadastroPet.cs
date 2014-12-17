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


            nome = txtNome.Text;
            dataDeNascimento = mkdDatadeNascimento.Text;
            raca = txtRaca.Text;
            rga = mktRGA.Text;

            DAOPet pet = new DAOPet();

            pet.inserePet(nome, dataDeNascimento, raca, rga);







        }
    }
}

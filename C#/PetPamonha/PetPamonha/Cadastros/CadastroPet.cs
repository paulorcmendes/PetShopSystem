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
            int dono;



            nome = txtNome.Text;
            dataDeNascimento = mkdDatadeNascimento.Text;
            raca = txtRaca.Text;
            rga = mktRGA.Text;
            dono = (int)cmbDono.SelectedValue;

            Pet pet = new Pet();

            pet.Nome = nome;
            pet.DataDeNascimento = dataDeNascimento;
            pet.Raca = raca;
            pet.RGA = rga;
            pet.Dono = dono;


            DAOPet daoPet = new DAOPet();
            daoPet.inserePet(pet);

            txtNome.Text="";
            mkdDatadeNascimento.Clear();
            txtRaca.Text = "";
            mktRGA.Clear();
        }



        private void CadastroPet_Load(object sender, EventArgs e){
            DAOCliente c = new DAOCliente();
            
            this.cmbDono.DataSource = c.getListClientes();
            this.cmbDono.DisplayMember = "nomeCPF";
            this.cmbDono.ValueMember = "idCliente";
         }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mktRGA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

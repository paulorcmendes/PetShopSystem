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
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Checkin_Load(object sender, EventArgs e)
        {
           
            DAOPet daoPet = new DAOPet();

            for (int i = 0; i < daoPet.pets.Count; i++)
            {

                cmbNome.Items.Add(daoPet.getListPets()[i].Nome);

            }

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {


            /* pessoas, peço que olhem o form "CadastroPet". Acho que ele foi modificado... por via das dúvidas eu escolhi passar o nome do pet como parâmetro. */

            String nome;
            nome = cmbNome.Text;

            DAOPet daoPet = new DAOPet();

            daoPet.removePet(nome);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

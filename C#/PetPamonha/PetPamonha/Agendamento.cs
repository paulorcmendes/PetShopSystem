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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            DAOPet daoPet = new DAOPet();

            for (int i = 0; i < daoPet.pets.Count; i++)
            {

                cmbNome.Items.Add(daoPet.getListPets()[i].Nome);

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            String nome;
            DateTime data;

            nome = cmbNome.Text;
            data = dtpData.Value.Date; // converter para o formato "dd/MM/yy" (String) compatível com o formato do banco de dados na classe DAO.
















        }
    }
}

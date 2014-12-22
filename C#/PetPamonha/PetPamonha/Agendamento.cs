using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetPamonha.DAO;
using PetPamonha.Classes_com_Properties;

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
            DAOTratamento daoTratamento = new DAOTratamento();

            this.cmbNome.DataSource = daoPet.getListPets();
            this.cmbNome.DisplayMember = "nomeRGA";
            this.cmbNome.ValueMember = "idPet";

            this.cmbTratamento.DataSource = daoTratamento.getListTratamentos();
            this.cmbTratamento.DisplayMember = "descricao";
            this.cmbTratamento.ValueMember = "idTratamento";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            PetTratamento tratamento = new PetTratamento();

            tratamento.IdPet=(int)this.cmbNome.SelectedValue;
            tratamento.IdTratamento = (int)this.cmbTratamento.SelectedValue;
            tratamento.DataHora = this.dtpData.Value.ToString();
            tratamento.Estado = true;

            DAOPetTratamento petTratamento = new DAOPetTratamento();

            petTratamento.inserePetTratamento(tratamento);
            this.Close();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pet pet = (Pet)this.cmbNome.SelectedItem;
            this.txtRaca.Text = pet.Raca;
            this.txtRGA.Text = pet.DataDeNascimento;
        }

        private void petBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

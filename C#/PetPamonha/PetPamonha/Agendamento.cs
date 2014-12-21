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
            DAOTratamento daoTratamento = new DAOTratamento();

            this.cmbNome.DataSource = daoPet.getListPets();
            this.cmbNome.DisplayMember = "Nome";
            this.cmbNome.ValueMember = "idPet";

            this.cmbTratamento.DataSource = daoTratamento.getListTratamentos();
            this.cmbTratamento.DisplayMember = "Nome";
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
            String nome;
            DateTime data;

            nome = cmbNome.Text;
            data = dtpData.Value.Date; // converter para o formato "dd/MM/yy" (String) compatível com o formato do banco de dados na classe DAO.
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.cmbNome.SelectedValue);
        }

        private void petBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

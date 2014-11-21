using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetPamonha.Cadastros;

namespace PetPamonha
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void menuPet_Click(object sender, EventArgs e)
        {
            CadastroPet cadastroPet = new CadastroPet();
            cadastroPet.Show();
        }

        private void menuTratamento_Click(object sender, EventArgs e)
        {
            CadastroTratamento cadastroTratamento = new CadastroTratamento();
            cadastroTratamento.Show();
        }

        private void menuListaDePets_Click(object sender, EventArgs e)
        {
            ListadePets listadePets = new ListadePets();
            listadePets.Show();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Checkin checkin = new Checkin();
            checkin.Show();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Show();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetPamonha.Cadastros;
using PetPamonha.DAO;
using PetPamonha.Classes_com_Properties;

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
            cadastroCliente.ShowDialog(this);
        }

        private void menuPet_Click(object sender, EventArgs e)
        {
            CadastroPet cadastroPet = new CadastroPet();
            cadastroPet.ShowDialog(this);
        }

        private void menuTratamento_Click(object sender, EventArgs e)
        {
            CadastroTratamento cadastroTratamento = new CadastroTratamento();
            cadastroTratamento.ShowDialog(this);
        }

        private void menuListaDePets_Click(object sender, EventArgs e)
        {
            ListadePets listadePets = new ListadePets();
            listadePets.ShowDialog(this);
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            atualizarListV();
        }

        private void atualizarListV()
        {
            this.listView1.Items.Clear();
            List<PetTratamento> listaDeTratamentos = new List<PetTratamento>();
            DAOPetTratamento petTratamento = new DAOPetTratamento();
            listaDeTratamentos = petTratamento.getListTratamentos();
            Formatador f = new Formatador();

            for (int i = 0; i < listaDeTratamentos.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                Pet pet = new Pet();
                Tratamento tratamento = new Tratamento();
                Cliente cliente = new Cliente();
                pet = new DAOPet().localizar(listaDeTratamentos[i].IdPet);
                tratamento = new DAOTratamento().localizar(listaDeTratamentos[i].IdTratamento);
                cliente = new DAOCliente().localizar(pet.Dono);

                String data = listaDeTratamentos[i].DataHora;
                Boolean estado = listaDeTratamentos[i].Estado;

                if (estado == true)
                {
                    item.Text = pet.Nome;
                    item.SubItems.Add(pet.RGA);
                    item.SubItems.Add(cliente.Nome);
                    item.SubItems.Add(cliente.Telefone);
                    item.SubItems.Add(tratamento.Nome);
                    item.SubItems.Add(listaDeTratamentos[i].DataHora);
                    item.SubItems.Add(f.calcularTermino(listaDeTratamentos[i].DataHora, tratamento.DuracaoMedia));
                    item.SubItems.Add("Em Andamento");

                    this.listView1.Items.Add(item);
                }

            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if(this.listView1.Items.Count>0){
                String rga = this.listView1.SelectedItems[0].SubItems[1].Text;
                DAOPet daoPet = new DAOPet();
                DAOPetTratamento petTratamento = new DAOPetTratamento();
                petTratamento.remover(daoPet.localizar(rga).IdPet);
                this.listView1.SelectedItems[0].Remove();
            }
            else{
                MessageBox.Show("Selecione na tabela o que você quer remover!","Erro");
            }
        }

        private void finalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadePets listadePets = new ListadePets();
            listadePets.ShowDialog(this);
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog(this);
            this.atualizarListV();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ShowDialog(this);
            this.atualizarListV();
        }

    }
}

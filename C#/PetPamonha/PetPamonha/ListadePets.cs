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
    public partial class ListadePets : Form
    {
        public ListadePets()
        {
            InitializeComponent();
        }

        private void ListadePets_Load(object sender, EventArgs e)
        {
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

                if (estado == false)
                {
                    item.Text = pet.Nome;
                    item.SubItems.Add(pet.RGA);
                    item.SubItems.Add(cliente.Nome);
                    item.SubItems.Add(cliente.Telefone);
                    item.SubItems.Add(tratamento.Nome);
                    item.SubItems.Add(listaDeTratamentos[i].DataHora);
                    item.SubItems.Add(f.calcularTermino(listaDeTratamentos[i].DataHora, tratamento.DuracaoMedia));
                    item.SubItems.Add("Finalizado");

                    this.listView2.Items.Add(item);
                }

            }
        }


        private void listAnimaisTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

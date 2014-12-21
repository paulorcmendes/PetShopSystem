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
    public partial class ListadePets : Form
    {
        public ListadePets()
        {
            InitializeComponent();
        }

        private void ListadePets_Load(object sender, EventArgs e)
        {
            ListViewItem item= new ListViewItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String rga;
            rga = txtRGAterminados.Text;

            DAOTratamento daoTratamento = new DAOTratamento();

            /*daoTratamento.removeTratamento(rga);*/





        }

        private void listAnimaisTratamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

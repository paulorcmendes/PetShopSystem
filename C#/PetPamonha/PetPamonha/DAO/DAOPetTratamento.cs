using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetPamonha.Classes_com_Properties;

namespace PetPamonha.DAO
{
    class DAOPetTratamento
    {
        private MySqlConnection con;

        public DAOPetTratamento()
        {
            this.con = new Conexao().Con;
        }

        public void inserePetTratamento(PetTratamento petTratamento)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO cliente (idPet,idTratamento,dataHora,estado) VALUES(@idPet,@idTratamento,@dataHora,@estado)";
                cmd.Parameters.AddWithValue("@idPet", petTratamento.IdPet);
                cmd.Parameters.AddWithValue("@idTratamento", petTratamento.IdTratamento);
                cmd.Parameters.AddWithValue("@dataHora", petTratamento.DataHora);
                cmd.Parameters.AddWithValue("@estado", petTratamento.Estado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
        }


        public List<Cliente> getListTratamentos()
        {
            MySqlDataReader leitor;
            List<Cliente> clientes = null;
            try
            {
                this.con.Open();
                clientes = new List<Cliente>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from cliente";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Cliente c = new Cliente();
                    c.IdCliente = (int)leitor["idCliente"];
                    c.Nome = (String)leitor["Nome"];
                    c.CPF = (String)leitor["CPF"];
                    c.Email = (String)leitor["Email"];
                    c.Telefone = (String)leitor["Telefone"];
                    clientes.Add(c);
                }
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.con.Close();
            }
            return clientes;
        }
    }
}

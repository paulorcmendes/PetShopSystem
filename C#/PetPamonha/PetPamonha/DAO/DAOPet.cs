using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetPamonha.DAO;
namespace PetPamonha
{
    class DAOPet
    {
        private MySqlConnection con;

        public DAOPet()
        {
            this.con = new Conexao().Con;
        }
        
        public void inserePet(Pet pet)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into pet (nome,dataDeNascimento,rga,raca,idCliente) values(@nome,@dataDeNascimento,@rga,@raca,@idCliente)";
                cmd.Parameters.AddWithValue("@nome", pet.Nome);
                cmd.Parameters.AddWithValue("@dataDeNascimento", pet.DataDeNascimento);
                cmd.Parameters.AddWithValue("@rga", pet.RGA);
                cmd.Parameters.AddWithValue("@raca", pet.Raca);
                cmd.Parameters.AddWithValue("@idCliente", pet.IdPet);
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

        public void removePet(Pet pet)
        {
        }

       public List<Pet> getListPets()
        {
            MySqlDataReader leitor;
            List<Pet> pets = null;
            try
            {
                this.con.Open();
                pets = new List<Pet>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from pet";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Pet p = new Pet();
                    p.IdPet = (int)leitor["idPet"];
                    p.Nome = (String)leitor["nome"];
                    p.DataDeNascimento = Convert.ToString(leitor["dataDeNascimento"]);
                    p.Raca = (String)leitor["raca"];
                    p.RGA = (String)leitor["rga"];
                    pets.Add(p);
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
            return pets;
        }
    }
}

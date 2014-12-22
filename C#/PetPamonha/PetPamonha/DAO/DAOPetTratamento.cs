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
        private Formatador formatar;

        public DAOPetTratamento()
        {
            this.con = new Conexao().Con;
            this.formatar = new Formatador();
        }

        public void inserePetTratamento(PetTratamento petTratamento)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO petTratamento (idPet,idTratamento,dataHora,estado) VALUES(@idPet,@idTratamento,@dataHora,@estado)";
                cmd.Parameters.AddWithValue("@idPet", petTratamento.IdPet);
                cmd.Parameters.AddWithValue("@idTratamento", petTratamento.IdTratamento);
                petTratamento.DataHora = formatar.formatarDataHora(petTratamento.DataHora);
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


        public List<PetTratamento> getListTratamentos()
        {
            MySqlDataReader leitor;
            List<PetTratamento> tratamentos = null;
            try
            {
                this.con.Open();
                tratamentos = new List<PetTratamento>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from petTratamento";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    PetTratamento p = new PetTratamento();
                    p.IdPet = (int)leitor["idPet"];
                    p.IdTratamento= (int)leitor["idTratamento"];
                    p.DataHora = Convert.ToString(leitor["dataHora"]);
                    p.Estado= Convert.ToBoolean(leitor["estado"]);
                    tratamentos.Add(p);
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
            return tratamentos;
        }

        public void remover(int idPet)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update petTratamento set estado = 0 where idPet = "+idPet;
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
    }
}

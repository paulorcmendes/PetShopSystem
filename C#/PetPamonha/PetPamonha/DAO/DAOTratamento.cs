using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using PetPamonha.DAO;

namespace PetPamonha
{
    class DAOTratamento
    {
        private MySqlConnection con;

        public DAOTratamento()
        {
            this.con = new Conexao().Con;
        }
        
        public void insereTratamento(Tratamento tratamento)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into tratamento (nome,valor,duracaoMedia) values(@nome,@valor,@duracaoMedia)";
                cmd.Parameters.AddWithValue("@nome", tratamento.Nome);
                cmd.Parameters.AddWithValue("@valor", tratamento.Preco);
                cmd.Parameters.AddWithValue("@duracaoMedia", tratamento.DuracaoMedia);
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

        public List<Tratamento> getListTratamentos()
        {
            MySqlDataReader leitor;
            List<Tratamento> tratamentos = null;
            try
            {
                this.con.Open();
                tratamentos = new List<Tratamento>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from tratamento";
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    Tratamento t = new Tratamento();
                    t.IdTratamento = (int)leitor["idTratamento"];
                    t.Nome = (String)leitor["nome"];
                    t.Preco = Convert.ToString(leitor["valor"]);
                    t.DuracaoMedia = Convert.ToString(leitor["duracaoMedia"]);
                    tratamentos.Add(t);
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

        public Tratamento localizar(int id)
        {
            MySqlDataReader leitor;
            Tratamento tratamento = null;
            try
            {
                this.con.Open();
                tratamento = new Tratamento();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from tratamento where idTratamento = " + id;
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    tratamento.IdTratamento = id;
                    tratamento.Nome = (String)leitor["nome"];
                    tratamento.Preco = Convert.ToString(leitor["valor"]);
                    tratamento.DuracaoMedia = Convert.ToString(leitor["duracaoMedia"]);
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
            return tratamento;
        }

    }
}

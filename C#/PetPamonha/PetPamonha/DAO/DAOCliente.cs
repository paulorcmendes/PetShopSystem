using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using PetPamonha.DAO;


namespace PetPamonha
{
    class DAOCliente
    {
        private MySqlConnection con;

        public DAOCliente() {
            this.con = new Conexao().Con;
        }

        public void insereCliente(Cliente cliente)
        {
            try
            {
                this.con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO cliente (Nome,CPF,Telefone,Email) VALUES(@Nome,@CPF,@Telefone,@Email)";
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);            
            }
            finally{
                this.con.Close();
            }
        }


        public List<Cliente> getListClientes(){
            MySqlDataReader leitor;
            List<Cliente> clientes=null;
            try
            {
                this.con.Open();
                clientes = new List<Cliente>();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from cliente";
                leitor = cmd.ExecuteReader();

                while(leitor.Read()){
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

        public Cliente localizar(int id)
        {
            MySqlDataReader leitor;
            Cliente c = null;
            
            try
            {
                this.con.Open();
                c = new Cliente();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from cliente where idCliente = " + id;
                leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    c.IdCliente = id;
                    c.Nome = (String)leitor["Nome"];
                    c.CPF = (String)leitor["CPF"];
                    c.Telefone= (String)leitor["Telefone"];
                    c.Email = (String)leitor["Email"];
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
            return c;
        }
    }
}

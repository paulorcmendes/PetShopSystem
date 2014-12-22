using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PetPamonha.DAO
{
    class Conexao
    {
        private MySqlConnection con;
        private String conexao = "server=localhost;database=petpamonha;uid=root;password=tadashi";

        public MySqlConnection Con
        {
            get
            {
                return con = new MySqlConnection(this.conexao);
            }
        }
    }
}

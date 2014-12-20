using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PetPamonha.DAO
{
    class conexao
    {
        private MySqlConnection con;
        String conexao = "server=localhost;database=petpamonha;uid=root;password=    ";

        public MySqlConnection Con {
            get {
                return con = new MySqlConnection(this.conexao);            
            }
        }
    }
}

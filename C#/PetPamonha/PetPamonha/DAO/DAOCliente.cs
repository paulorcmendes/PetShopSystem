using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace PetPamonha
{

    


    class DAOCliente
    {


        public List<Cliente> clientes = new List<Cliente>();


        internal void insereCliente(string nome, string cpf, string email, string telefone)
        {

            throw new NotImplementedException();


        }


        List<Cliente> getListClientes(){
        
            return clientes;
        
        }


        
       







    }
}

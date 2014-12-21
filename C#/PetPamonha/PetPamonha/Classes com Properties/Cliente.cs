using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class Cliente
    {

        private int idCliente;
        private String nome;
        private String cpf;
        private String email;
        private String telefone;




        public int IdCliente{
            get {
                return this.idCliente;
            }
            set {
                this.idCliente = value;
            }
        }
        public String Nome
        {


            get
            {
                return this.nome;
            }



            set
            {
                this.nome = value;
            }


        }

        public String CPF
        {


            get
            {
                return this.cpf;
            }



            set
            {
                this.cpf = value;
            }


        }

        public String Email
        {


            get
            {
                return this.email;
            }



            set
            {
                this.email = value;
            }


        }

        public String Telefone
        {


            get
            {
                return this.telefone;
            }



            set
            {
                this.telefone = value;
            }


        }











    }
}

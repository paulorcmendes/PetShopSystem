using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class Tratamento
    {

        private String nome;
        private String preço;
        private String duracaoMedia;

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



        public String Preço
        {


            get
            {
                return this.preço;
            }



            set
            {
                this.preço = value;
            }


        }

        public String DuracaoMedia
        {


            get
            {
                return this.duracaoMedia;
            }



            set
            {
                this.duracaoMedia = value;
            }


        }


    }
}

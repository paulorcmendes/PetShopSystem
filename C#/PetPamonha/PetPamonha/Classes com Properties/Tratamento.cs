using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class Tratamento
    {
        private int idTratamento;
        private String nome;
        private String preco;
        private String duracaoMedia;
        private String descricao;

        public String Descricao
        {
            get
            {
                this.descricao = this.nome + " - R$" + this.preco + " - " + this.duracaoMedia;
                return this.descricao;
            }
        }
        public int IdTratamento 
        {
            get {
                return this.idTratamento;
            }
            set {
                this.idTratamento = value;
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



        public String Preco
        {


            get
            {
                return this.preco;
            }

            set
            {
                this.preco = value;
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

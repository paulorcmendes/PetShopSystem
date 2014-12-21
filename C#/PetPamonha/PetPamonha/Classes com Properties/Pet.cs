using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class Pet
    {
        private int idPet;
        private String nome;
        private String dataDeNascimento;
        private String raca;
        private String rga;
        private int dono;


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

        public String DataDeNascimento
        {
            get
            {
                return this.dataDeNascimento;
            }
            set
            {
                this.dataDeNascimento = value;
                this.formatarData(this.dataDeNascimento);
            }
        }

        public String Raca
        {
            get
            {
                return this.raca;
            }
            set
            {
                this.raca = value;
            }
        }

        public String RGA
        {
            get
            {
                return this.rga;
            }
            set
            {
                this.rga = value;
            }
        }
        
        public int Dono
        {
            get
            {
                return this.dono;
            }
            set
            {
                this.dono = value;
            }
        }
        
        public int IdPet {
            set {
                this.idPet = value;
            }
            get {
                return this.idPet;
            }   
        }

        private void formatarData(String data){
            if (data.ElementAt(2).Equals('/'))
            {
                String dia, mes, ano;
                dia = this.dataDeNascimento.Substring(0, 2);
                mes = this.dataDeNascimento.Substring(3, 2);
                ano = this.dataDeNascimento.Substring(6, 4);
                String dataFormt = ano + "/" + mes + "/" + dia;
                this.dataDeNascimento = dataFormt;
            }
            else {
                String dia, mes, ano;
                dia = this.dataDeNascimento.Substring(0, 4);
                mes = this.dataDeNascimento.Substring(5, 2);
                ano = this.dataDeNascimento.Substring(8, 2);
                String dataFormt = ano + "/" + mes + "/" + dia;
                this.dataDeNascimento = dataFormt;
            }
            
        }
    }
}

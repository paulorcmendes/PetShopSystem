using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha.Classes_com_Properties
{
    class PetTratamento
    {
        private int idPet;
        private int idTratamento;
        private String dataHora;
        private Boolean estado;

        public int IdPet {
            set {
                this.idPet = value;
            }
            get {
                return this.idPet;
            }
        }
        public int IdTratamento {
            set {
                this.idTratamento = value;
            }
            get {
                return this.idTratamento;
            }
        }
        public String DataHora
        {
            set
            {
                this.dataHora = value;
            }
            get
            {
                return this.dataHora;
            }
        }
        public Boolean Estado
        {
            set
            {
                this.estado = value;
            }
            get
            {
                return this.estado;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetPamonha
{
    class DAOPet
    {

        //atributos
        public List<Pet> pets = new List<Pet>();



        internal void inserePet(string nome, string dataDeNascimento, string raca, string rga, string dono)
        {

            throw new NotImplementedException();


        }



        internal void removePet(string nome)
        {
            throw new NotImplementedException();
        }




        internal List<Pet> getListPets()
        {

            return pets;

        }


    }
}

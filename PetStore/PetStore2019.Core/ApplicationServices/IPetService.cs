using System;
using System.Collections.Generic;
using PetStore2019.Core.Entities;

namespace PetStore2019.Core.ApplicationServices
{
    public interface IPetService
    {
        List<Pet> GetPets();
        List<Pet> SearchPets(Enum petEnum);
        void CreatPet(Pet pet);
        void DeletePet(int id);
        void UpdatePet(int id, Pet pet);
        List<Pet> SortPetsByPrice();
        List<Pet> GetCheapestFivePets();
        Pet SearchPetById(int id);
    }
}
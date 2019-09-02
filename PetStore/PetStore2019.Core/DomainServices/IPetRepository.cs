using System.Collections.Generic;
using PetStore2019.Core.Entities;
namespace PetStore2019.Core.DomainServices
{
    public interface IPetRepository
    {
        //Create Pet
        Pet CreatePet(Pet pet);
        //Read Pets
        Pet ReadByID(int id);

        List<Pet> ReadAllPets();
        //Update Pets
        Pet UpdatePet(Pet petUpdate, int id);
        //Delete Pet
        Pet DeletePetByID(int id);
    }
}

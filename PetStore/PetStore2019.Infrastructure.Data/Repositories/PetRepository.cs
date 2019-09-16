using System;
using System.Collections.Generic;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;

namespace PetStore2019.Infrastructure.Data.Repositories
{
    public class PetRepository: IPetRepository
    {
        
        public Pet CreatePet(Pet pet)
        {
            pet.Id = FakeDB.id++;
            FakeDB._pets.Add(pet);
            return pet;
        }

        public Pet ReadByID(int id)
        {
            foreach (var pet in FakeDB._pets)
            {
                if (pet.Id == id)
                    return pet;
            }

            return null;
        }

        public List<Pet> ReadAllPets()
        {
            return FakeDB._pets;
        }


        public Pet UpdatePet(Pet petUpdate, int id)
        {
            var petFromDB = this.ReadByID(id);
            if (petFromDB != null)
            {
                petFromDB.Birthdate = petUpdate.Birthdate;
                petFromDB.Color = petUpdate.Color;
                petFromDB.Name = petUpdate.Name;
                petFromDB.PreviousOwner = petUpdate.PreviousOwner;
                petFromDB.Price = petUpdate.Price;
                petFromDB.Race = petUpdate.Race;
                petFromDB.SoldDate = petUpdate.SoldDate;
                return petFromDB;
            }

            return null;
        }

        public Pet DeletePetByID(int id)
        {
            var petFound = this.ReadByID(id);
            if (petFound != null)
            {
                FakeDB._pets.Remove(petFound);
            }

            return petFound;
        }
    }
}

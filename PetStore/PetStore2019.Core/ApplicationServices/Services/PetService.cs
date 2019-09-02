using System;
using System.Collections.Generic;
using System.Text;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;

namespace PetStore2019.Core.ApplicationServices.Services
{
    public class PetService: IPetService
    {
        private IPetRepository _petRepository;
        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }


        public List<Pet> GetPets()
        {
            return _petRepository.ReadAllPets();
        }

        public List<Pet> SearchPets(Enum petEnum)
        {
            List<Pet> Petsfound = new List<Pet>();
            foreach (var Pat in _petRepository.ReadAllPets())
            {
                if(Pat.Race.Equals(petEnum))
                    Petsfound.Add(Pat);
            }
            return Petsfound;
        }

        public void CreatPet(Pet pet)
        {
            _petRepository.CreatePet(pet);
        }

        public void DeletePet(int id)
        {
            _petRepository.DeletePetByID(id);
        }

        public void UpdatePet(int id, Pet pet)
        {
            _petRepository.UpdatePet(pet,id);
        }

        public List<Pet> SortPetsByPrice()
        {
            List<Pet> petsByPrice = new List<Pet>();
            petsByPrice.AddRange(_petRepository.ReadAllPets());
            petsByPrice.Sort((pet1, pet2) => pet1.Price.CompareTo(pet2.Price));
            return _petRepository.ReadAllPets();

        }

        public List<Pet> GetCheapestFivePets()
        {
            return SortPetsByPrice().GetRange(0, 5);
        }

        public Pet SearchPetById(int id)
        {
            return _petRepository.ReadByID(id);
        }
    }
}

using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore2019.Infrastructure.Data.SQL.Repositories
{
    class PetSQLRepository : IPetRepository
    {

        private PetshopContext _context;

        public PetSQLRepository(PetshopContext context)
        {
            _context = context;
        }
        public Pet CreatePet(Pet pet)
        {
            Pet petToReturn = _context.Attach(pet).Entity;
            _context.SaveChanges();
            return petToReturn;
        }

        public Pet DeletePetByID(int id)
        {
            Pet petToReturn = _context.Remove(new Pet() { Id = id }).Entity;
            _context.SaveChanges();
            return petToReturn;
        }

        public List<Pet> ReadAllPets()
        {
            return _context.pets.ToList();
        }

        public Pet ReadByID(int id)
        {
            return _context.pets.Find(id);
        }

        public Pet UpdatePet(Pet petUpdate, int id)
        {
            throw new NotImplementedException();
        }
    }
}

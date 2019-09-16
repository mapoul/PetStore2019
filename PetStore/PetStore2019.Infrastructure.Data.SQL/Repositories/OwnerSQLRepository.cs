using Microsoft.EntityFrameworkCore;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore2019.Infrastructure.Data.SQL.Repositories
{
    class OwnerSQLRepository : IOwnerRepository
    {
        private PetshopContext _context;
        public OwnerSQLRepository(PetshopContext context)
        {
            _context = context;
        }
        public Owner CreateOwner(Owner owner)
        {

            Owner ownerToReturn = _context.Attach(owner).Entity;
            _context.SaveChanges();
            return ownerToReturn;
        }

        public Owner DeleteOwnerByID(int id)
        {
            Owner ownerToReturn = _context.Remove(new Owner() { Id = id }).Entity;
            _context.SaveChanges();
            return ownerToReturn;
        }

        public List<Owner> ReadAllOwner()
        {
            return _context.owners.ToList();
        }

        public Owner ReadByID(int id)
        {
            return _context.owners.Find(id);
        }

        public Owner UpdateOwner(Owner ownerUpdate, int id)
        {
            throw new NotImplementedException();
        }
    }
}

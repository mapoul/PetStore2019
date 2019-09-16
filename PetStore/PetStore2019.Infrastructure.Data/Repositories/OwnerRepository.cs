using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;
using System;
using System.Collections.Generic;

namespace PetStore2019.Infrastructure.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner CreateOwner(Owner owner)
        {
            owner.Id = FakeDB.id++;
            FakeDB._Owners.Add(owner);
            return owner;
        }

        public Owner DeleteOwnerByID(int id)
        {
            var ownerFound = this.ReadByID(id);
            if (ownerFound != null)
            {
                FakeDB._Owners.Remove(ownerFound);
            }

            return null;
        }

        public List<Owner> ReadAllOwner()
        {
            return FakeDB._Owners;
        }

        public Owner ReadByID(int id)
        {
            foreach (var owner in FakeDB._Owners)
            {
                if (owner.Id == id)
                    return owner;
            }

            return null;
        }

        public Owner UpdateOwner(Owner ownerUpdate, int id)
        {
            var ownerFromDB = this.ReadByID(id);
            if (ownerFromDB != null)
            {
                
                ownerFromDB.FirstName = ownerUpdate.FirstName;
                ownerFromDB.LastName = ownerUpdate.LastName;
                
                return ownerFromDB;
            }

            return null;
        }
    }
}

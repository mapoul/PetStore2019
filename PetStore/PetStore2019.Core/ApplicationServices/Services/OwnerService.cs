using System;
using System.Collections.Generic;
using System.Text;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;

namespace PetStore2019.Core.ApplicationServices.Services
{
    public class OwnerService : IOwnerService
    {

        private IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public void CreateOwner(Owner owner)
        {
            _ownerRepository.CreateOwner(owner);
        }

        public void DeleteOwner(int id)
        {
            _ownerRepository.DeleteOwnerByID(id);
        }

        public List<Owner> GetOwners()
        {
            return _ownerRepository.ReadAllOwner();
        }

        public Owner SearchOwnerById(int id)
        {
           return _ownerRepository.ReadByID(id);
        }

        public void UpdateOwner(int id, Owner owner)
        {
            _ownerRepository.UpdateOwner(owner, id);
        }
    }
}

using System.Collections.Generic;
using PetStore2019.Core.Entities;


namespace PetStore2019.Core.ApplicationServices
{
    public interface IOwnerService
    {
        List<Owner> GetOwners();
        void CreateOwner(Owner owner);
        void DeleteOwner(int id);
        void UpdateOwner(int id, Owner owner);
        Owner SearchOwnerById(int id);
    }
}

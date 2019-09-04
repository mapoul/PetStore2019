using System.Collections.Generic;
using PetStore2019.Core.Entities;


namespace PetStore2019.Core.ApplicationServices
{
    public interface IOwnerService
    {
        List<Owner> GetOwner();
        void CreateOwner(Owner owner);
        void DeleteOwner(int id);
        void UpdateOwner(int id, Pet pet);
        Owner SearchOwnerById(int id);
    }
}

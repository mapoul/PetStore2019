using PetStore2019.Core.Entities;
using System.Collections.Generic;


namespace PetStore2019.Core.DomainServices
{
    public interface IOwnerRepository
    {
        //Create Pet
        Owner CreateOwner(Owner owner);
        //Read Pets
        Owner ReadByID(int id);

        List<Owner> ReadAllOwner();
        //Update Pets
        Owner UpdatePet(Owner ownerUpdate, int id);
        //Delete Pet
        Owner DeleteOwnerByID(int id);
    }
}

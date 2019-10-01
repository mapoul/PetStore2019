using PetStore2019.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore2019.Infrastructure.Data.SQL
{
    public class DBInitializer
    {
        

        public static void Seed(PetshopContext dataContext)
        {
            var pet1 = new Pet
            {
                Name = "Fiddo",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "White",
                Race = Pet.Species.Hund,
                Price = 2500,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            

            var pet2 = new Pet()
            {
                Name = "Buller",
                Birthdate = new DateTime(1953, 4, 2),
                Color = "Green",
                Race = Pet.Species.Ged,
                Price = 1337,
                PreviousOwner = "Camilla Møller Andersen",
                SoldDate = new DateTime(2019, 8, 30)
            };
            

            var pet3 = new Pet()
            {
                Name = "Plet",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Spotted",
                Race = Pet.Species.Kat,
                Price = 205,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            

            var pet4 = new Pet()
            {
                Name = "Kvik",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Black",
                Race = Pet.Species.Hund,
                Price = 5000,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };


            var pet5 = new Pet()
            {
                Name = "Fede",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Grey",
                Race = Pet.Species.Kat,
                Price = 300,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };


            var pet6 = new Pet()
            {
                Name = "Balter",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Brown",
                Race = Pet.Species.Ged,
                Price = 1200,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };

            dataContext.Add(pet1);
            dataContext.Add(pet2);
            dataContext.Add(pet3);
            dataContext.Add(pet4);
            dataContext.Add(pet5);
            dataContext.Add(pet6);

            var owner1 = new Owner
            {
                FirstName = "Burger",
                LastName = "Bolle"
            };
            var owner2 = new Owner
            {
                FirstName = "Gunnar",
                LastName = "Galahat"
            };
            var owner3 = new Owner
            {
                FirstName = "Karl",
                LastName = "Kalashnikov"
            };
            dataContext.Add(owner1);
            dataContext.Add(owner2);
            dataContext.Add(owner3);

            dataContext.SaveChanges();

        }


    }
}

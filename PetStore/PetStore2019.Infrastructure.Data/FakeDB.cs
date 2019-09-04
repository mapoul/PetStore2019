using System;
using System.Collections.Generic;
using System.Text;
using PetStore2019.Core.Entities;

namespace PetStore2019.Infrastructure.Data
{
    public class FakeDB
    {
        public static int id = 1;
        public static List<Pet> _pets = new List<Pet>();
        public static List<Owner> _Owners = new List<Owner>();


        public static void initData()
        {
            var pet1 = new Pet()
            {
                Id = id++,
                Name = "Fiddo",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "White",
                Race = Pet.Species.Hund,
                Price = 2500,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            _pets.Add(pet1);

            var pet2 = new Pet()
            {
                Id = id++,
                Name = "Buller",
                Birthdate = new DateTime(1953, 4, 2),
                Color = "Green",
                Race = Pet.Species.Ged,
                Price = 1337,
                PreviousOwner = "Camilla Møller Andersen",
                SoldDate = new DateTime(2019, 8, 30)
            };
            _pets.Add(pet2);

            var pet3 = new Pet()
            {
                Id = id++,
                Name = "Plet",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Spotted",
                Race = Pet.Species.Kat,
                Price = 205,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            _pets.Add(pet3);

            var pet4 = new Pet()
            {
                Id = id++,
                Name = "Kvik",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Black",
                Race = Pet.Species.Hund,
                Price = 5000,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            _pets.Add(pet4);

            var pet5 = new Pet()
            {
                Id = id++,
                Name = "Fede",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Grey",
                Race = Pet.Species.Kat,
                Price = 300,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            _pets.Add(pet5);

            var pet6 = new Pet()
            {
                Id = id++,
                Name = "Balter",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "Brown",
                Race = Pet.Species.Ged,
                Price = 1200,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            _pets.Add(pet6);
        }

    }
}

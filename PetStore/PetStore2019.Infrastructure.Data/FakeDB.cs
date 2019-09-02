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
    }
}

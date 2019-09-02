﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore2019.Core.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Species Race { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public string PreviousOwner { get; set; }
        public double Price { get; set; }

        public enum Species
        {
            Kat, Hund, Ged 
        }



        
    }
}

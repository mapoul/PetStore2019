using Microsoft.EntityFrameworkCore;
using PetStore2019.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore2019.Infrastructure.Data.SQL
{
    public class PetshopContext : DbContext
    {

        public PetshopContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Pet> pets { get; set; }
        public DbSet<Owner> owners { get; set; }
    }
}

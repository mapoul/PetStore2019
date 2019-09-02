using System;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;
using PetStore2019.Infrastructure.Data.Repositories;

namespace PetStore2019.ConsoleApp
{
    class Program
    {
        private static IPetRepository petRepsitory;
        static void Main(string[] args)
        {
           var consoleMenu = new ConsoleMenu();
           consoleMenu.RunMenu();
        }

        
    }
}

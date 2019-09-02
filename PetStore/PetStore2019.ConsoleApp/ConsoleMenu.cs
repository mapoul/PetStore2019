using System;
using System.Collections.Generic;
using PetStore2019.Core.ApplicationServices;
using PetStore2019.Core.ApplicationServices.Services;
using PetStore2019.Core.DomainServices;
using PetStore2019.Core.Entities;
using PetStore2019.Infrastructure.Data.Repositories;

namespace PetStore2019.ConsoleApp
{
    
    class ConsoleMenu
    {
        private IPetRepository petRepository;
        private IPetService petService;

        public ConsoleMenu()
        {
            petRepository = new PetRepository();
            petService = new PetService(petRepository);
            initData();
        }


        public void initData()
        {
            var pet1 = new Pet()
            {
                Name = "Fiddo",
                Birthdate = new DateTime(2018, 3, 19),
                Color = "White with brown spots",
                Race = Pet.Species.Hund,
                Price = 2500,
                PreviousOwner = "Tonni Bonde",
                SoldDate = new DateTime(2019, 6, 24)
            };
            petRepository.CreatePet(pet1);

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
            petRepository.CreatePet(pet2);
        }
       
        public void RunMenu()
        {
            
            

            int number;

            MenuText();

            var number1 = int.TryParse(Console.ReadLine(), out number);

            SelectedItem(number);

        }

        public void SelectedItem(int number)
        {

            while (number > 8 || number < 1)
            {
                MenuText();
                Console.WriteLine("Please type one of the valid numbers shown above");
                var number1 = int.TryParse(Console.ReadLine(), out number);

            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("List all Pets has been chosen");
                    ListAllPets();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 2:
                    Console.WriteLine("Add a Pet has been chosen");
                    AddPet();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 3:
                    Console.WriteLine("Edit a Pet has been chosen");
                    EditPet();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 4:
                    Console.WriteLine("Delete Video has been chosen");
                    DeletePet();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 5:
                    Console.WriteLine("Search For a Pet has been chosen");
                    SearchPet();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 6:
                    //Sort pets by price
                    Console.WriteLine("Sort pets by price has been chosen");
                    SortPetsByPrice();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                case 7:
                    //Get 5 cheapest pets
                    Console.WriteLine("Get 5 cheapest pet has been chosen");
                    Get5CheapestPets();
                    Console.WriteLine("\nPress enter to get back to the menu");
                    Console.ReadLine();
                    RunMenu();
                    break;
                default:
                    Console.WriteLine("You have exited");
                    break;

            }
        }

        private List<Pet> Get5CheapestPets()
        {
            return petService.GetCheapestFivePets();
        }

        private List<Pet> SortPetsByPrice()
        {
            return petService.SortPetsByPrice();
        }

        private List<Pet> SearchPet()
        {
            Console.WriteLine("Type the race you want to find");
            var Race = Console.ReadLine();
            var species = Pet.Species.Kat;

            switch (Race)
            {
                case "Ged":
                    species = Pet.Species.Ged;
                    break;
                case "Hund":
                    species = Pet.Species.Hund;
                    break;
                case "Kat":
                    species = Pet.Species.Kat;
                    break;
                default:
                    break;

            }
            return petService.SearchPets(species);
        }

        private void EditPet()
        {
            Console.WriteLine("Type ID: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Birthdate of the Pet");
            Console.WriteLine("Year: ");
            var year = Console.ReadLine();
            Console.WriteLine("Month: ");
            var month = Console.ReadLine();
            Console.WriteLine("Day: ");
            var day = Console.ReadLine();
            Console.WriteLine("Color: ");
            var color = Console.ReadLine();
            Console.WriteLine($"Choose Race: {Pet.Species.Ged}, {Pet.Species.Hund}, {Pet.Species.Kat}");
            var Race = Console.ReadLine();
            var species = Pet.Species.Kat;

            switch (Race)
            {
                case "Ged":
                    species = Pet.Species.Ged;
                    break;
                case "Hund":
                    species = Pet.Species.Hund;
                    break;
                case "Kat":
                    species = Pet.Species.Kat;
                    break;
                default:
                    break;

            }
            Console.WriteLine("Price: ");
            var price = Console.ReadLine();
            Console.WriteLine("Name of previous owner: ");
            var previousOwner = Console.ReadLine();
            Console.WriteLine("Last Sold Date");
            Console.WriteLine("Year: ");
            var year1 = Console.ReadLine();
            Console.WriteLine("Month: ");
            var month1 = Console.ReadLine();
            Console.WriteLine("Day: ");
            var day1 = Console.ReadLine();

            var pet = new Pet
            {
                Name = name,
                Birthdate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)),
                Color = color,
                Race = species,
                Price = int.Parse(price),
                PreviousOwner = previousOwner,
                SoldDate = new DateTime(int.Parse(year1), int.Parse(month1), int.Parse(day1))
            };
            petService.UpdatePet(id,pet);
        }

        Pet FindPetById()
        {
            Console.WriteLine("Type Pet id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please use a number");
            }

            return petService.SearchPetById(id);
        }

        void DeletePet()
        {
            var petFound = FindPetById();
            if (petFound != null)
            {
                petService.DeletePet(petFound.Id);
            }
        }

        void AddPet()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Birthdate of the Pet");
            Console.WriteLine("Year: ");
            var year = Console.ReadLine();
            Console.WriteLine("Month: ");
            var month = Console.ReadLine();
            Console.WriteLine("Day: ");
            var day = Console.ReadLine();
            Console.WriteLine("Color: ");
            var color = Console.ReadLine();
            Console.WriteLine($"Choose Race: {Pet.Species.Ged}, {Pet.Species.Hund}, {Pet.Species.Kat}");
            var Race = Console.ReadLine();
            var species = Pet.Species.Kat;

            switch (Race)
            {
                case "Ged":
                    species = Pet.Species.Ged;
                    break;
                case "Hund":
                    species = Pet.Species.Hund;
                    break;
                case "Kat":
                    species = Pet.Species.Kat;
                    break;
                default:
                    break;
                    
            }
            Console.WriteLine("Price: ");
            var price = Console.ReadLine();
            Console.WriteLine("Name of previous owner: ");
            var previousOwner = Console.ReadLine();
            Console.WriteLine("Last Sold Date");
            Console.WriteLine("Year: ");
            var year1 = Console.ReadLine();
            Console.WriteLine("Month: ");
            var month1 = Console.ReadLine();
            Console.WriteLine("Day: ");
            var day1 = Console.ReadLine();

            var pet = new Pet
            {
                Name = name,
                Birthdate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)),
                Color = color,
                Race = species,
                Price = int.Parse(price),
                PreviousOwner = previousOwner,
                SoldDate = new DateTime(int.Parse(year1), int.Parse(month1), int.Parse(day1))
            };
            petService.CreatPet(pet);
        }

        void ListAllPets()
        {
            Console.WriteLine("\nList of Pets");
            var pets = petRepository.ReadAllPets();
            foreach (var pet in pets)
            {
                Console.WriteLine($"Id: {pet.Id} Name: {pet.Name} Birthdate: {pet.Birthdate} Color: {pet.Color} Race: {pet.Race} Price: {pet.Price} Previous Owner: {pet.PreviousOwner} Sold Date: {pet.SoldDate}");
            }

            Console.WriteLine("\n");
        }

        public void MenuText()
        {
            List<string> MenuItems = new List<string>();

            MenuItems.Add("Press 1 to: List all Pets");
            MenuItems.Add("Press 2 to: Add a Pet");
            MenuItems.Add("Press 3 to: Edit a Pet");
            MenuItems.Add("Press 4 to: Delete a Pet");
            MenuItems.Add("Press 5 to: Search for a Pet");
            MenuItems.Add("Press 6 to: Sort Pets by price");
            MenuItems.Add("Press 7 to: List the 5 cheapest pets");
            MenuItems.Add("Press 8 to: Exit");

            foreach (var item in MenuItems)
            {

                Console.WriteLine(item);
            }

        }
    }
}

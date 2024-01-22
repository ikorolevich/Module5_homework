using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Module5_homework
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            (string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetNames, int FavColor, string[] FavColors) User;
            User = EnterUser();
            ShowUser(User.Name,User.LastName,User.Age,User.IsAnyPet,User.Pets,User.PetNames,User.FavColor,User.FavColors);
            return;
        }

        public static (string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetNames, int FavColor, string[] FavColors) EnterUser()
        {
            (string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetNames, int FavColor, string[] FavColors) User;
            Console.WriteLine("Enter the Name");
            User.Name = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            User.Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you have a pet ? -  Y / N");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                User.IsAnyPet = true;
                Console.WriteLine("How many pets do you have ?");
                User.Pets = Convert.ToInt16(Console.ReadLine());
                User.PetNames = GetPetNames(User.Pets);
            }
            else
            {
                User.IsAnyPet = false;
                User.Pets = 0;
                User.PetNames = GetPetNames(User.Pets);
            }

            Console.WriteLine("How many fav. colors do you have");
            User.FavColor = Convert.ToInt16(Console.ReadLine());
            
            if (User.FavColor > 0)
            {
                User.FavColors = GetFavColors(User.FavColor);
            }
            else
            {
                User.FavColors = GetFavColors(User.FavColor);
            }
            
            return User;
        }
        public static string[] GetPetNames( int NumOfPets)
        {
            string[] PetNames = new string[NumOfPets];
            for (int i = 0; i < NumOfPets; i++)
            {
                Console.WriteLine("Enter a {0} pet name", i+1);
                PetNames[i] = Console.ReadLine();
            }
            return PetNames;
        }
        public static string[] GetFavColors(int numOfcolors)
        {
            string[] favColors = new string[numOfcolors];
            for (int i = 0; i < numOfcolors; i++)
            {
                Console.WriteLine("Enter a {0} favorite color", i + 1);
                favColors[i] = Console.ReadLine();
            }
            return favColors;
        }

        public static void ShowUser(string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetNames, int FavColor, string[] FavColors)
        {
            Console.WriteLine();
            Console.WriteLine("The user name is {0}  {1} , age is {2}", Name, LastName, Age);
            Console.WriteLine("{0} has {1} pets",Name,Pets);
            if (IsAnyPet) {
                Console.WriteLine("Pets names:");
                for (int i = 0; i < Pets; i++)
                {
                    Console.WriteLine(PetNames[i]);
                }
            }
            Console.WriteLine("{0} has {1} favorite colors", Name, FavColor);
            if (FavColor != 0)
            {
                Console.WriteLine("Favorite colors:");
                for(int i = 0;i < FavColors.Length; i++)
                {
                    Console.WriteLine(FavColors[i]);
                }
            }

        }
    }
}

using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Module5_homework
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           

        }

        public static (string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetName, int FavColor, string[] FavColors) EnterUser()
        {
            (string Name, string LastName, int Age, bool IsAnyPet, int Pets, string[] PetName, int FavColor, string[] FavColors) User;
            Console.WriteLine("Enter the Name");
            User.Name = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            User.Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you have a pet ? -  Y / N");
            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                User.IsAnyPet = true;
                Console.WriteLine("How many pets do you have ?");
                User.Pets = Convert.ToInt16(Console.ReadLine());
                User.PetName = GetPetNames(User.Pets);
            }
            else
            {
                User.IsAnyPet = false;
                User.Pets = 0;
                User.PetName = GetPetNames(User.Pets);
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
    }
}

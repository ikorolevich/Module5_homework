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
            TryNum("age", out User.Age);
            Console.WriteLine("Do you have a pet ? -  Y / N");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                User.IsAnyPet = true;
                TryNum("the number of pets you have", out User.Pets);
                User.PetNames = GetPetNames(User.Pets);
            }
            else
            {
                User.IsAnyPet = false;
                User.Pets = 0;
                User.PetNames = GetPetNames(User.Pets);
            }
            TryNum("the number of favorites colors",out User.FavColor);
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
        public static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int result))
            {
                if (result >= 0)
                {
                    corrnumber = result;
                    return true;
                }
                else
                {
                    corrnumber=0;
                    return false;
                }
            }
            else{ 
                corrnumber=0;
                return false; 
            }

        }
        public static void TryNum (string input, out int age)
        {
            const int ATTEMPTS = 2;
            int NumOfAttempts = 1;
            do
            {
                Console.WriteLine("Enter {0}",input);
                if (CheckNum(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    if (NumOfAttempts > ATTEMPTS)
                    {
                        Console.WriteLine("Exit");
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Incorrect value, try again");
                    NumOfAttempts++;
                }
            } while (true);

        }
    }
}

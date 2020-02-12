using System;

namespace WebSystemscSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            string nameInput = TakeUserName();
            int gradeInput = TakeUserGrade();
            Student User = allocateUserInfromation(nameInput,gradeInput);
        }

        private static string TakeUserName()
        {
            try
            {
                Console.Write("Please Enter your full name :");
                string userInput = Console.ReadLine();
                Console.Clear();
                return userInput;
            }



            catch (Exception e)
            {
                Console.WriteLine("Unable to intake this value, please try again");
                Console.WriteLine("Listed Error :" + e);
                
                TakeUserName();
            }

            string User = "User";
            return User;
        }   

        private static int TakeUserGrade()
        {
            
            try
            {
                Console.Write("Please Enter your grade level :");
                String preParse = Console.ReadLine();
                int userInput = int.Parse(preParse);
                    if(userInput > 5 || userInput < 0)
                    {
                    Console.WriteLine("Invalid Entry, Please enter a number between 1 and 5");
                    TakeUserGrade();
                    }
                Console.Clear();
                return userInput;
            }

            catch ( Exception e)
            {
                Console.WriteLine("Unable to parse this value");
                Console.WriteLine("Listed Error :" + e);
                TakeUserGrade();
            }
            int failed = 0;
            return failed;
        }

        private static void Welcome()
        {
            Console.WriteLine("Welcome to Blue Sky Tutoring");
            Console.WriteLine("You will soon be asked to enter information about yourself so we can make the perfect tutor for you");
        }

        private static Student allocateUserInfromation(string nameIn, int gradeIn)
        {
            Student User = new Student(gradeIn, nameIn );
            return User;
        }
    }
}

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
            Student User = new Student();
            User.grade = gradeInput;
            User.name = nameInput;

            int Quit = 0;
            int correct = 0;
            int wrong = 0;
            do
            {
                int selection2 = Menu(User.grade);
                switch (selection2)
                {
                    case 1:
                        int checkadd = Add();
                        if (checkadd == 1)
                        {
                            correct++;
                        }
                        else
                        {
                            wrong++;
                        }
                        break;

                    case 2:
                        int checksub = Subtract();
                        if (checksub == 1)
                        {
                            correct++;
                        }
                        else
                        {
                            wrong++;
                        }
                        break;
                    case 3:
                        int checkdiv = Division();
                        if (checkdiv == 1)
                        {
                            correct++;
                        }
                        else
                        {
                            wrong++;
                        }
                        break;

                    case 4:
                        int checkMul = Multiply();
                        if (checkMul == 1)
                        {
                            correct++;
                        }
                        else
                        {
                            wrong++;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Thank you for my program");
                        Console.WriteLine("you got :" + correct + " right");
                        Console.WriteLine("you got :" + wrong + " wrong");
                        Quit++;
                        break;
                    default:
                        Console.WriteLine("Something went wrong, please try again");
                        break;
                }
            } while (Quit == 0);
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


           
            
                Console.Write("Please Enter your grade level :");
                String preParse = Console.ReadLine();
                int grade = int.Parse(preParse);
                if(grade > 5 || grade < 0)
                {
                    Console.WriteLine("Grade invalid, please try again");
                    TakeUserGrade();
                }
            
                return grade;
           

          


           
            
        }

        private static void Welcome()
        {
            Console.WriteLine("Welcome to Blue Sky Tutoring");
            Console.WriteLine("You will soon be asked to enter information about yourself so we can make the perfect tutor for you");
        }

    

        private static int Menu(int User)
        {
            int Usergrade = User;

            switch (Usergrade)
            {
                case 1:
                    Console.WriteLine("enter 1 to add");
                    Console.WriteLine("enter 2 to Subtract");
                    Console.WriteLine("enter 9 to exit program");
                    try
                    {
                        string Input = Console.ReadLine();
                        int Gradelvl = int.Parse(Input);
                        return Gradelvl;

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
                case 2:
                    Console.WriteLine("enter 1 to add");
                    Console.WriteLine("enter 2 to Subtract");
                    Console.WriteLine("enter 9 to exit program");
                    try
                    {
                        string Input = Console.ReadLine();
                        int Gradelvl = int.Parse(Input);
                        return Gradelvl;

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;

                case 3:
                    Console.WriteLine("enter 1 to add");
                    Console.WriteLine("enter 2 to Subtract");
                    Console.WriteLine("enter 3 to Multiply");
                    Console.WriteLine("enter 9 to exit program");
                    try
                    {
                        string Input = Console.ReadLine();
                        int Gradelvl = int.Parse(Input);
                        return Gradelvl;

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;

                case 4:
                    Console.WriteLine("enter 1 to add");
                    Console.WriteLine("enter 2 to Subtract");
                    Console.WriteLine("enter 3 to Multiply");
                    Console.WriteLine("enter 4 to Divide");
                    Console.WriteLine("enter 9 to exit program");
                    try
                    {
                        string Input = Console.ReadLine();
                        int Gradelvl = int.Parse(Input);
                        return Gradelvl;

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
                case 5:
                    Console.WriteLine("enter 1 to add");
                    Console.WriteLine("enter 2 to Subtract");
                    Console.WriteLine("enter 3 to Multiply");
                    Console.WriteLine("enter 4 to Divide");
                    Console.WriteLine("enter 9 to exit program");
                    try
                    {
                        string Input = Console.ReadLine();
                        int Gradelvl = int.Parse(Input);
                        return Gradelvl;

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
                default:
                    Console.WriteLine("Grade Level: N/A");
                    return 5;
                    break;

            }

            return 5;

        }

        private static int Add()
        {
            Random rand = new Random();
            int firstNumber = rand.Next(20);
            int secondnumber = rand.Next(20);
            Console.Write("Please answer: " + firstNumber + " + " + secondnumber + "  :");
            int answer = firstNumber + secondnumber;
            string input = Console.ReadLine();
            int check = int.Parse(input);

            if (check == answer)
            {
                Console.WriteLine("Good Job!! your answer of  " + answer + " was right!!");
                return 1;
            }

            else
            {
                Console.WriteLine("So close!! " + answer + " was the right answer please try again");
                return 0;
            }



        }

        private static int Subtract()
        {
            Random rand = new Random();
            int firstNumber = rand.Next(20);
            int secondnumber = rand.Next(20);
            Console.Write("Please answer: " + firstNumber + " - " + secondnumber + "  :");
            int answer = firstNumber - secondnumber;
            string input = Console.ReadLine();
            int check = int.Parse(input);

            if (check == answer)
            {
                Console.WriteLine("Good Job!! your answer of  " + answer + " was right!!");
                return 1;
            }

            else
            {
                Console.WriteLine("So close!! " + answer + " was the right answer please try again");
                return 0;
            }
        }

        private static int Division()
        {
            Random rand = new Random();
            int firstNumber = rand.Next(10);
            int secondnumber = rand.Next(20);
            Console.Write("Please answer: " + firstNumber + " / " + secondnumber + "  :");
            int answer = firstNumber/secondnumber;
            string input = Console.ReadLine();
            int check = int.Parse(input);

            if (check == answer)
            {
                Console.WriteLine("Good Job!! your answer of  " + answer + " was right!!");
                return 1;
            }

            else
            {
                Console.WriteLine("So close!! " + answer + " was the right answer please try again");
                return 0;
            }
        }

        private static int Multiply()
        {
            Random rand = new Random();
            int firstNumber = rand.Next(20);
            int secondnumber = rand.Next(20);
            Console.Write("Please answer: " + firstNumber + " x " + secondnumber + "  :");
            int answer = firstNumber * secondnumber;
            string input = Console.ReadLine();
            int check = int.Parse(input);

            if (check == answer)
            {
                Console.WriteLine("Good Job!! your answer of  " + answer + " was right!!");
                return 1;
            }

            else
            {
                Console.WriteLine("So close!! " + answer + " was the right answer please try again");
                return 0;
            }
        }
    }
}

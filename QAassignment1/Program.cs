using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAassignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool toRepeatProg = true;
            int menuSelection;

            int width = ValidateWidthInput();
            int length = ValidateLengthInput();
            Rectangle rectangle = new Rectangle(length, width);

            while (toRepeatProg == true)
            {
                Console.WriteLine("What would you like to do with your " + width + " x " + length + " rectangle?\n");
                menuSelection = ValidateMenuSelection();
                

                switch (menuSelection)
                {
                    case 1:
                        Console.WriteLine("Length of rectangle: " + rectangle.GetLength() + "\n");
                        break;
                    case 2:
                        length = ValidateLengthInput();
                        rectangle.SetLength(length);
                        Console.WriteLine("New length of rectangle: " + rectangle.GetLength() + "\n");
                        break;
                    case 3:
                        Console.WriteLine("Width of rectangle: " + rectangle.GetWidth() + "\n");
                        break;
                    case 4:
                        width = ValidateWidthInput();
                        rectangle.SetWidth(width);
                        Console.WriteLine("New width of rectangle: " + rectangle.GetWidth() + "\n");
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of rectangle: " + rectangle.GetPerimeter() + "\n");
                        break;
                    case 6:
                        Console.WriteLine("Area of rectangle: " + rectangle.GetArea() + "\n");
                        break;
                    case 7:
                        toRepeatProg = false;
                        break;


                }
            }
                
            

        }

        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;
            int userInputInt = 0;

            while (validMenuSelect == false)
            {
                Console.WriteLine("Please, select available task from menu bellow, by entering a number of menu item\n");
                Console.WriteLine("1 -> Get rectangle length");
                Console.WriteLine("2 -> Change rectangle length");
                Console.WriteLine("3 -> Get rectangle width");
                Console.WriteLine("4 -> Change rectangle width");
                Console.WriteLine("5 -> Get rectangle perimeter");
                Console.WriteLine("6 -> Get rectangle area");
                Console.WriteLine("7 -> Exit the program\n");

                userInput = Console.ReadLine();

                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6" && userInput != "7")
                {
                    Console.WriteLine("Please, write correct number of menu item again\n");
                }
                else
                {
                    validMenuSelect = true;
                }

            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateWidthInput()
        {
            string userWidthInput = "";
            bool validWidthInput = false;
            int number = 1;

            while (validWidthInput == false)
            {
                Console.WriteLine("Please, write the width of rectangle (only integer): ");
                userWidthInput = Console.ReadLine();

                bool result = int.TryParse(userWidthInput, out number);

                if (result == false)
                {
                    Console.WriteLine("Sorry, incorrect input, try again\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Sorry, number should be more than 0\n");
                }
                else
                {
                    validWidthInput = true;
                }
            }
            Console.WriteLine();
            return number;
        }

        public static int ValidateLengthInput()
        {
            string userLengthInput = "";
            bool validLengthInput = false;
            int number = 1;

            while (validLengthInput == false)
            {
                Console.WriteLine("Please, write the length of rectangle (only integer): ");
                userLengthInput = Console.ReadLine();

                bool result = int.TryParse(userLengthInput, out number);

                if (result == false)
                {
                    Console.WriteLine("Sorry, incorrect input, try again\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Sorry, number should be more than 0\n");
                }
                else
                {
                    validLengthInput = true;
                }
            }
            Console.WriteLine();
            return number;
        }
    }
}

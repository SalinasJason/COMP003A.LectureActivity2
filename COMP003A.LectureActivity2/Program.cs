/*
  Author: Jason Salinas
  Course: COMP-003A
  Faculty: Jonathan Cruz
  Purpose: A program demonstrating statements, variables, and operators.
*/
namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 3.1: Delcare and initialize variables
            string userName; // Variable to store the user's name
            int userAge; // Variable to store the user's age
            double productPrice; // Variable to store the product price
            bool isStudent; // Variable to store if the user is a student (true/false)

            // Prompt the user to enter their name
            Console.Write("Enter your name: ");
            userName = Console.ReadLine(); // Read and assign the user's input to userName

            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine()); // Convert and assign the user's input to userAge

            // Prompt the user to enter the product price
            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine()); // Convert and assign the user's input to productPrice

            // Prompt the user to indicate if they are a student
            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine()); // Convert and assign the user's input to isStudent
        }
    }
}

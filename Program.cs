

namespace LearnC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter for username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

        }
    }
}
namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string name = "Sam";

            int age = 29;

            DisplayUserInfo($"Name: {name}, Age: {age}");
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!");
        }
        static void DisplayUserInfo(string message)
        {
            Console.WriteLine(message);
        }
    } 
}

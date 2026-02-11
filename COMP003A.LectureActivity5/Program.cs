namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string name = "Sam";

            int age = 29;

            int num1 = 5;

            int num2 = 7;

            int sum = CalculateSum(num1, num2);

            DisplayUserInfo($"Name: {name}, Age: {age}");

            Console.WriteLine("The sum is:" + "" + sum);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5!");
        }
        static void DisplayUserInfo(string message)
        {
            Console.WriteLine(message);
        }
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }
    } 
}

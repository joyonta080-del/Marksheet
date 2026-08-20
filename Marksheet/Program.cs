namespace Marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your Roll Number:");
            string rollnumber = Console.ReadLine();

            Console.Write("Enter your Semester:");
            string s = Console.ReadLine();
                    
            Console.Write("Enter your Web Development marks:");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Blockchain marks:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Advanced Python programming marks:");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Cryptography marks:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter your name: " + name);
            Console.WriteLine("Enter your Roll Number: " + rollnumber);
            Console.WriteLine("Enter your Semester: " + s);

            Console.WriteLine();
            int total = w + b + p + c;
            Console.WriteLine("Total marks: " + total);
            int percentage = total *100/240;
            Console.WriteLine("Percentage: " + percentage);



        }
    }
}

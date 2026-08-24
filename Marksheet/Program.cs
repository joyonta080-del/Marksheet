namespace Marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();

            //Console.Write("Enter your Roll Number:");
            //string rollnumber = Console.ReadLine();

            //Console.Write("Enter your Semester:");
            //string s = Console.ReadLine();
                    
            Console.Write("Enter your Web Development marks:");
            int percentage = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your Blockchain marks:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your Advanced Python programming marks:");
            //int p = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your Cryptography marks:");
            //int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //Console.WriteLine("Enter your name: " + name);
            //Console.WriteLine("Enter your Roll Number: " + rollnumber);
            //Console.WriteLine("Enter your Semester: " + s);

            //Console.WriteLine();
            //int total = w + b + p + c;
            //Console.WriteLine("Total marks: " + total);
            //int percentage = total *100/240;
            //Console.WriteLine("Percentage: " + percentage);


            if (percentage >=80 && percentage <= 100)
            {
                Console.WriteLine("Grade: A+");

            }
            else if (percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 40 && percentage < 50)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 0 && percentage < 40)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid marks entered.");
            }   

            //int supply = 0;
            //if (w < 24)
            //{
            //    supply++;
            //}
            //if (b < 18)
            //{
            //    supply++;
            //}
            //if (p < 24)
            //{
            //    supply++;
            //}
            //if (c < 24)
            //{
            //    supply++;
            //} 

            //Console.WriteLine ("You have {0} subjects in supply.", supply);




        }
    }
}

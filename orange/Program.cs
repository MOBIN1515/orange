using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

namespace orange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstname, lastname, gender = "male", phonenumber, robot;
            Console.WriteLine("plese enter your first name");
            firstname = Console.ReadLine();

            Console.WriteLine("plaese enter your last name");
            lastname = Console.ReadLine();

           
            Console.WriteLine("plaese enter your phonenumber");
             phonenumber = Console.ReadLine();

            if (phonenumber.StartsWith("09"))
            {

                Console.WriteLine("Phone number is correct. ");
            }
            else
            {
                Console.WriteLine("Phone number is not correct .");



            }

            string userage = default;
             int age =Convert.ToInt32(userage);
            

            Console.WriteLine("plaese enter your userage");
            userage = Console.ReadLine();

            Console.WriteLine("plaese enter your gender");
            gender = Console.ReadLine();

            if ((gender == "male" && age >= 18) || (gender == "female" && age >= 15))
            {
                Console.WriteLine(" you can sign up");
            }
            else
            {
                Console.WriteLine("you can not sing up");
            }












        }
    }
}

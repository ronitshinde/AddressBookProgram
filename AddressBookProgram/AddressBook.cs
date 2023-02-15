using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();

        public void CreateContact()
        {
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email Id");
            contact.Email = Console.ReadLine();
            Console.WriteLine();


        }
        public void Display()
        {
            Console.WriteLine("Contact Details As Mentioned Below " + "\n\n First Name : " + contact.FirstName + "\n Last Name : " + contact.LastName + "\n Address : " + contact.Address + "\n City : " + contact.City + "\n State : " + contact.State + "\n Zip : " + contact.Zip + "\n Phone Number : " + contact.PhoneNumber + "\n Email : " + contact.Email );
        }
    }
}

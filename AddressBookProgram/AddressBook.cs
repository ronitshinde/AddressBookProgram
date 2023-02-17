using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();

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

            contactList.Add(contact);
            Console.WriteLine();

        }
        public void Display()
        {
            foreach (var contact in contactList)
                Console.WriteLine("Contact Details As Mentioned Below " + "\n\n First Name : " + contact.FirstName + "\n Last Name : " + contact.LastName + "\n Address : " + contact.Address + "\n City : " + contact.City + "\n State : " + contact.State + "\n Zip : " + contact.Zip + "\n Phone Number : " + contact.PhoneNumber + "\n Email : " + contact.Email);
        }
        public void EditContact()
        {
            Console.WriteLine("Enter The First Name");
            string name = Console.ReadLine();
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1.First Name \n2.Last Name \n3.Address \n4.City \n5.State \n6.Zip \n7.Phone Number \n8.Email Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the new First Name");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the new Last Name");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the new Address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the new City");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the new State");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the new Zip");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter the new Phone Number");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the new Email");
                            contact.Email = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }
            }
        }
    }
}

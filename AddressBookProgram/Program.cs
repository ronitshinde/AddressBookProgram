using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book problem");
            AddressBook addBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1 : To Create Contact");
                Console.WriteLine("Select 2 : To Edit Created Contact");
                Console.WriteLine("Select 3 : To Display Existing Contact");
                Console.WriteLine("Select 4 : To Delete Existing Contact");
                Console.WriteLine("Select 5 : To Exit Creating Contact");
                Console.WriteLine("Select Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add New Contact");
                        addBook.CreateContact();
                        break;
                    case 2:
                        Console.WriteLine("Edit Contact");
                        addBook.EditContact();
                        break;
                    case 3:
                        Console.WriteLine("Display Contact Details");
                        addBook.Display();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Delete Contact");
                        addBook.DeleteContact();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}

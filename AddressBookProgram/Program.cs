using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book problem");
            AddressBook addBook = new AddressBook();
            addBook.CreateContact();
            addBook.Display();
            Console.ReadLine();
        }
    }
}

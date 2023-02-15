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
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Select 1 : To Create Contact");
                Console.WriteLine("Select 2 : To Exit Creating Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("");
                        addBook.CreateContact();
                        addBook.Display();
                        Console.ReadLine();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
            
        }
    }
}

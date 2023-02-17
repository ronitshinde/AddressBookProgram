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
            while (flag)
            {
                Console.WriteLine("Select 1 : To Create Contact");
                Console.WriteLine("Select 2 : To Edit Created Contact");
                Console.WriteLine("Select 3 : To Delete From Existing Contact");
                Console.WriteLine("Select 4 : To Exit Creating Contact");
                
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("");
                        addBook.CreateContact();
                        addBook.Display();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Edit Contact");
                        addBook.EditContact("Ronit");
                        addBook.Display();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Delete Contact");
                        addBook.DeleteContact("Ronit");
                        addBook.Display();
                        Console.ReadLine();
                        break;
                    case 4:
                        flag = false;
                        break;
                }

            }
        }
    }
}

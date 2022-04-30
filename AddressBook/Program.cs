using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {

        public static ManipulateContact manipulate = new ManipulateContact();

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book system");

            AddContact();
            EditContact();
            DeleteContact();
        }
        public static void AddContact()
        {

            Console.WriteLine("welcome to address book system");
            Console.WriteLine("how many contacts do you want to add?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                AddressContact detail = new AddressContact();
                ManipulateContact AddContact = new ManipulateContact();
                AddContact.AddingContact(
                    detail.Name = Console.ReadLine(),
                    detail.Address = Console.ReadLine(),
                    detail.City = Console.ReadLine(),
                    detail.State = Console.ReadLine(),
                    detail.ZipCode = Console.ReadLine(),
                    detail.PhoneNumber = Console.ReadLine(),
                    detail.Email = Console.ReadLine()
                    );

                Console.ReadLine();
            }
        }
        public static void EditContact()
        {
            //ContactDetails detail = new ContactDetails();
            //ManipulateContact EditNewContact = new ManipulateContact();
            Console.WriteLine("enter name you want edit");
            string Name = Console.ReadLine();
            manipulate.EditingContact(Name);
        }
        public static void DeleteContact()
        {
            Console.WriteLine("enter name you want delete");
            string Name = Console.ReadLine();
            manipulate.DeletingContact(Name);
        }
    }
}
    


﻿using AddressBookSystem;
using System.Collections;
Console.WriteLine("Welcome to Adddress book system");
int num;
string key = "z";


AddressBookDetails addressbook = new AddressBookDetails();

while (key != "n")
{
    Console.WriteLine("Select an Option");
    Console.WriteLine("1 - Addcontact, 2 - Display contact, 3 - Edit Contact, 4 - Delete Contact");
    num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            addressbook.AddContacts();
            break;
        case 2:
            addressbook.display();
            break;
        case 3:
            addressbook.EditContact();
            break;
        case 4:
            addressbook.DeleteContact();
            break;
    }
    Console.WriteLine("Do u want to continue? Press y/n");

    key = Console.ReadLine();
}
Console.ReadLine();
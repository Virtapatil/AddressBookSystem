namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            // Create sample contacts
            ContactsInAddress contact1 = new ContactsInAddress()
            {
                FirstName = "vir",
                LastName = "patil",
                Address = "Jannat",
                City = "Ngp",
                State = "NY",
                Zip = "10001",
                PhoneNumber = "1234567890",
                Email = "kyahilikhhu@gmail.com"
            };

            ContactsInAddress contact2 = new ContactsInAddress()
            {
                FirstName = "Virta",
                LastName = "Patil",
                Address = "Jha koi aata jata nahi",
                City = "Jadu ki Nagari",
                State = "Maharashtra",
                Zip = "90001",
                PhoneNumber = "7709523217",
                Email = "vir33@gmail.com"
            };

            // Add contacts to the address book
            addressBook.AddContact(contact1);
            addressBook.AddContact(contact2);

            // Display all contacts in the address book
            addressBook.DisplayContacts();

            Console.ReadLine();
        }
    }
}
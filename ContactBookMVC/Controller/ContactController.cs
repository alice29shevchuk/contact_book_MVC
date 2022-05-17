using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMVC.Controller
{
    public class ContactController
    {
        private List<Contact> contactsList { get; set; }
        WriteReadController writeReadController = new WriteReadController();
        public ContactController(List<Contact> contactsList)
        {
            this.contactsList = contactsList;
        }
        public ContactController()
        {
            this.contactsList = new List<Contact>();
            writeReadController.Read(this);
        }
        public void AddContact(Contact contact)
        {
            if (contact != null)
            {
                contact.Id = this.contactsList.Count + 1;
                contactsList.Add(contact);
                writeReadController.Write(contactsList);
            }
        }
        public void DeleteContact(Contact contact)
        {
            contactsList.Remove(contact);
        }
        public List<Contact> GetContacts()
        {
            return contactsList;
        }
    }
}

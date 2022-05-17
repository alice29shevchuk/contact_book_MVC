using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMVC.Controller
{
    public class WriteReadController
    {
        public List<Contact> contacts { get; set; }
        public string Path;
        public WriteReadController()
        {
            Path = "PhoneBook.txt";
        }
        public void Write(List<Contact> contactsList)
        {
            File.Delete(Path);
            foreach (var item in contactsList)
            {
                File.AppendAllText(Path, item.GetInfoContact() + "\n");
            }
        }
        public void Read(ContactController contactController)
        {
            string str = File.ReadAllText(Path);
            string[] masStr = str.Split('\n');
            for (int i = 0; i < masStr.Length-1; i++)
            {
                string val = masStr[i];
                string[] masVal = val.Split(' ', '|');
                Contact contact = new Contact(masVal[1], masVal[2], masVal[3],new List<string> { "098765543"});
                contactController.AddContact(contact);
            }
        }
    }
}

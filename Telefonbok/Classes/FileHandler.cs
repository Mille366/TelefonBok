using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telefonbok.Classes
{
   public class FileHandler
    {

        private string filePath;

        public FileHandler(string path)
        {
            filePath = @"C:\Users\Milto\Downloads\user.txt";
        }
        public void AddContactToFile(string contact)
        {
            using (StreamWriter file = File.AppendText(filePath))
            {
                file.WriteLine(contact);
            }

        }

        public void SaveUsersToFile(List<User> users)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false)) // false för att skriva över
            {
                foreach (User user in users)
                {
                    string line = $"{user.Name}, {user.Email}, {user.Adress}, {user.ZipCode}, {user.PostCode}, {user.PhoneNumber}";
                    writer.WriteLine(line);
                }
            }
        }

    }

}
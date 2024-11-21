using Telefonbok.Classes;

namespace Telefonbok
{
    public partial class Form1 : Form
    {

        public List<User> userList = new List<User>();


        public Form1()
        {
            InitializeComponent();
            listBoxContact.SelectedIndexChanged += SelectedUser;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User user = new User(textBoxName.Text, textBoxEMail.Text, textBoxAdress.Text, textBoxZipCode.Text,
                                                                textBoxPostCode.Text, textBoxPhoneNumber.Text);
            string contact = $"{user.Name}, {user.Email}, {user.Adress},{user.ZipCode}, {user.PostCode}, {user.PhoneNumber}";

            listBoxContact.Items.Add(contact);

            FileHandler fileHandler = new FileHandler(@"C:\Users\Milto\Downloads\user.txt");
            fileHandler.AddContactToFile(contact);


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string searchCondition = textBoxSearch.Text.ToLower();

            List<string> searchResult = new List<string>();
            string[] lines = File.ReadAllLines(@"C:\Users\Milto\Downloads\user.txt");

            listBoxContact.Items.Clear();
            userList.Clear();

            foreach (string line in lines)
            {
                string[] userData = line.Split(',');

                User currentUser = new User(userData[0], userData[1], userData[2], userData[3], userData[4], userData[5]);

                if ((currentUser.Name != null && currentUser.Name.ToLower().Contains(searchCondition)) ||
            (currentUser.PostCode != null && currentUser.PostCode.ToString().ToLower().Contains(searchCondition)))
                {
                    string contact1 = $"{currentUser.Name}, {currentUser.Email}, {currentUser.Adress}, {currentUser.ZipCode}, {currentUser.PostCode}, {currentUser.PhoneNumber}";

                    searchResult.Add(contact1);
                    userList.Add(currentUser);
                }
            }


            if (searchResult.Count > 0)
            {
                foreach (string result in searchResult)
                {
                    listBoxContact.Items.Add(result);
                }
            }



        }
        private void ShowUserInfo(User user)
        {
            if (user != null)
            {
                textBoxName.Text = user.Name;
                textBoxEMail.Text = user.Email;
                textBoxAdress.Text = user.Adress;
                textBoxZipCode.Text = user.ZipCode;
                textBoxPostCode.Text = user.PostCode;
                textBoxPhoneNumber.Text = user.PhoneNumber;
            }


        }

        private void SelectedUser(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedItems.Count > 0)
            {
                User selectedUser = userList[listBoxContact.SelectedIndex];
                ShowUserInfo(selectedUser);

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex >= 0)
            {
                // Hämta den valda användaren
                User selectedUser = userList[listBoxContact.SelectedIndex];

                // Uppdatera användarens information baserat på textfälten
                selectedUser.Name = textBoxName.Text;
                selectedUser.Email = textBoxEMail.Text;
                selectedUser.Adress = textBoxAdress.Text;
                selectedUser.ZipCode = textBoxZipCode.Text;
                selectedUser.PostCode = textBoxPostCode.Text;
                selectedUser.PhoneNumber = textBoxPhoneNumber.Text;

                // Spara tillbaka till filen via FileHandler
                FileHandler fileHandler = new FileHandler(@"C:\Users\Milto\Downloads\user.txt");
                fileHandler.SaveUsersToFile(userList);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxContact.SelectedIndex;

                userList.RemoveAt(selectedIndex);

                listBoxContact.Items.RemoveAt(selectedIndex);

                FileHandler fileHandler = new FileHandler(@"C:\Users\Milto\Downloads\user.txt");
                fileHandler.SaveUsersToFile(userList); // Spara de uppdaterade användarna
            }
        }
    }
}
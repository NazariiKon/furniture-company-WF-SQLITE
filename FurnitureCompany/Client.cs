namespace FurnitureCompany
{
    public class Client
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public Client()
        {
            
        }

        public Client(long id, string name, string surname, string login, 
            string password, string email, string adress, string phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Email = email;
            Adress = adress;
            Phone = phone;
        }
    }

}
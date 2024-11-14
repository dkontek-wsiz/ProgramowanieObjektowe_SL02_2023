

namespace Lab2.Models
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;
        private string pesel;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } 
            set {
                if (value > 0) age = value;
                else age = 0;
            } }
        public string Pesel => pesel;// { get { return pesel; } }

        public Person() {
            name = "Test";
        }

        public Person(string name) { 
            this.name = name;   
        }

        public void Welcome()
        {
            Console.WriteLine("Witaj");
        }

        public void Welcome(string otherName)
        {
            Console.WriteLine($"Witaj {otherName} Jestem {Name}");
        }

        public void Welcome(int otherName)
        {
            Console.WriteLine($"Witaj {otherName} Jestem {Name}");
        }


        public static Person Create()
        {
            return new Person();
        }

        public static Person MapUser(User n)
        {
            return new Person(n.UserName);
        }
    }
}

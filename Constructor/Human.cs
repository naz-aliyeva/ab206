namespace Constructor
{
    internal class Human
    {

        public Human()
        {
        }
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Human(string name)
        {

            this.name = name;
        }
        public Human(string name, string surname, byte age) : this(name, surname)
        {
            age = age;
        }

        public string name;
        public string surname;
        public byte age;


        public void ShowFullData()
        {
            Console.WriteLine($"Name:{name}, Surname{surname}, Age:{age}");
        }

        public string GetFullData()
        {
            string fullname = this.name + "" + this.surname;
            return fullname;
        }
    }


}

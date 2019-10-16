using System;
namespace simpsons_net_web_api.Modules
{
    public class Character
    {
        Int64 id;
        string firstName;
        string secondName;
        string lastName;
        int age;
        int height;
        int weight;
        string birthDate;
        string photo;
        string job;
        string description;

        public Character(){}

        public Character(string firstName)
        {
            this.firstName = firstName;
        }

        public Character(Int64 id, string firstName, string secondName, string lastName, int age, int height, int weight, string birthDate, string photo, string job, string description) : this(firstName)
        {
            this.id = id;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.birthDate = birthDate;
            this.photo = photo;
            this.job = job;
            this.description = description;
        }

        public Int64 Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value;}
        public string SecondName { get => secondName; set => secondName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Job { get => job; set => job = value; }
        public string Description { get => description; set => description = value; }
    }    

}
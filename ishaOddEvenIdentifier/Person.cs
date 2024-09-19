namespace OddEven
{
    class Person 
    {
        string _name; int age;

        public Person(string name, int age) 
        {
            _name = name;
            this.age = age;
        }

        public Person() { }
        public static Person GetPerson(string name, int age)
        {
            Person person = new Person();
            person._name = name;
            person.age = age;

            return person;
        }

        public static Person GetPerson(string name)
        {
            Person person = new Person();
            person._name = name;

            return person;
        }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hi I'm {_name} and I'm {age} years old.");
        }
    }

}
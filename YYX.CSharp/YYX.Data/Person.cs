namespace YYX.Data
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
            : this(string.Empty, 0)
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var person = obj as Person;
            if (person != null)
            {
                return string.Equals(name, person.name);
            }

            return false;
        }

        protected bool Equals(Person other) => string.Equals(name, other.name);

        public override int GetHashCode() => (name != null ? name.GetHashCode() : 0);

        public static bool operator ==(Person left, Person right) => Equals(left, right);

        public static bool operator !=(Person left, Person right) => !Equals(left, right);
    }
}

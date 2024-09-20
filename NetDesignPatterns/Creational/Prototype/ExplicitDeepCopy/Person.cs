namespace NetDesignPatterns.Creational.Prototype.ExplicitDeepCopy
{
    public class Person : IPrototype<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names ?? throw new ArgumentNullException(nameof(names));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }
    }
}
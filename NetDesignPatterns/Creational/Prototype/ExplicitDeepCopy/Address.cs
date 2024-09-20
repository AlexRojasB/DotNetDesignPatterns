namespace NetDesignPatterns.Creational.Prototype.ExplicitDeepCopy
{
    public class Address : IPrototype<Address>
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
            HouseNumber = houseNumber;
        }

        public Address DeepCopy()
        {
            return new Address(StreetName, HouseNumber);
        }
    }
}
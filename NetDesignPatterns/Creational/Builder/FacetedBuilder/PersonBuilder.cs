namespace NetDesignPatterns.Creational.Builder.FacetedBuilder
{
    public class PersonBuilder
    {
        protected Person person = new();

        public PersonJobBuilder Works => new(person);
        public PersonAddressBuilder Lives => new(person);

        public static implicit operator Person(PersonBuilder pb) => pb.person;
    }    
}
namespace NetDesignPatterns.Creational.Builder.FacetedBuilder
{
    public class Person
    {
        public string Name;

        // Address
        public string StreetAddress, Postcode, City;

        // employment
        public string CompanyName;
        public int AnnualIncome;
        public string Position;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
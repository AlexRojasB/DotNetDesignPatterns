namespace NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics
{
    public class PersonJobBuilder<SELF> 
    : PersonInfoBuilder<PersonJobBuilder<SELF>> 
    where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAsA(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }
}
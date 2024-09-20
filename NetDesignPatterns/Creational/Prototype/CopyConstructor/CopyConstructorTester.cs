namespace NetDesignPatterns.Creational.Prototype.CopyConstructor
{
    public class CopyConstructorTester
    {
        public void RunTest(bool canRun)
        {
            if(!canRun)return;

            var john =  new Person(["John", "Smoth"], new Address("London Road", 123));

            var jane = new Person(john);
            jane.Address.HouseNumber = 321;
        }
    }
}
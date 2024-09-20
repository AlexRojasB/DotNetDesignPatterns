namespace NetDesignPatterns.Creational.Prototype.ExplicitDeepCopy
{
    public class ExplicitDeepCopyTester
    {
        public void RunTest(bool canRun)
        {
            if(!canRun)return;

            var john =  new Person(["John", "Smoth"], new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Address.HouseNumber = 321;
        }
    }
}
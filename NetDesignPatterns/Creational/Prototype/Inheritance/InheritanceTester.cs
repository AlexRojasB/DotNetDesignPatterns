namespace NetDesignPatterns.Creational.Prototype.Inheritance
{
    public class InheritanceTester
    {
        public void RunTest(bool canRun)
        {
            if(!canRun)return;

            var john =  new Employee(["John", "Smoth"], new Address("London Road", 123), 100);

            var jane = john.DeepCopy(); // use extension methods to avoid john.DeepCopy<Employee>()
            jane.Address.HouseNumber = 321;
        }
    }
}
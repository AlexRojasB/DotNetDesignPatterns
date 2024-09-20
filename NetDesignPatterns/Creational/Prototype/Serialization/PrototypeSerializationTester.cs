namespace NetDesignPatterns.Creational.Prototype.Serialzation
{
    public class PrototypeSerializationTester
    {
         public void RunTest(bool canRun = false)
        {
            if(!canRun)return;

            var john =  new Person(["John", "Smoth"], new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
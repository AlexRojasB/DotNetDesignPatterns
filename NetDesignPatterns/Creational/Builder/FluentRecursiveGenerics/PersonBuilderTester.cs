namespace NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics
{
    public class PersonBuilderTester
    {
        public  void RunTest(bool canRun = false)
        {
            if(!canRun)
            {
                return;
            }
           var person =  Person.New
            .Called("Alex")
            .WorkAsA("Programmer")
            .Build();
            Console.WriteLine(person);
        }
    }
}
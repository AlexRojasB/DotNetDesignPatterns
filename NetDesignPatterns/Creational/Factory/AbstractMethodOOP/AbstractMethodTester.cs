namespace NetDesignPatterns.Creational.Factory.AbstractMethodOOP
{
    public class AbstractMethodTesterOOP 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
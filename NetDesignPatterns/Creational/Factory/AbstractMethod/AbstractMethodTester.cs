namespace NetDesignPatterns.Creational.Factory.AbstractMethod
{
    public class AbstractMethodTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(AvailableDrink.Tea, 100);
            drink.Consume();
        }
    }
}
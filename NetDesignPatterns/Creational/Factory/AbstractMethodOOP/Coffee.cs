namespace NetDesignPatterns.Creational.Factory.AbstractMethodOOP
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
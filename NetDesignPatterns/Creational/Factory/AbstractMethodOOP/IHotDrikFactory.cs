namespace NetDesignPatterns.Creational.Factory.AbstractMethodOOP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
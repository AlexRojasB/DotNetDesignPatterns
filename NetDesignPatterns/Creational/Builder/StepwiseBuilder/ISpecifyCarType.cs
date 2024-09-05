namespace NetDesignPatterns.Creational.Builder.StepwiseBuilder
{
    public interface ISpecifyCarType 
    {
        ISpecifyWheelSize OfType(CarType type);
    }
}
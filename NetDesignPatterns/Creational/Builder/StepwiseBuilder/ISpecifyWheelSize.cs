namespace NetDesignPatterns.Creational.Builder.StepwiseBuilder
{
    public interface ISpecifyWheelSize 
    {
        IBuildCar WithWheels(int size);
    }
}
namespace NetDesignPatterns.Creational.Builder.StepwiseBuilder
{
    public class StepwiseBuilderTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var car = CarBuilder.Create() // ISpecifyCarType
            .OfType(CarType.Crossover) // ISpecifyWheelSize
            .WithWheels(18) // IBuildCar
            .Build();
        }
    }
}
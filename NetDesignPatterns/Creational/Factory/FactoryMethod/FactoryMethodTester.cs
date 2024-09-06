namespace NetDesignPatterns.Creational.Factory.FactoryMethod
{
    public class FactoryMethodTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var point = Point.NewPolarPoint(1.0, Math.PI/2);
            Console.WriteLine(point);
        }
    }
}
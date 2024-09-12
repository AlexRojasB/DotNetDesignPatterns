namespace NetDesignPatterns.Creational.Factory.InnerFactory
{
    public class FactoryMethodTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI/2);
            Console.WriteLine(point);
        }
    }
}
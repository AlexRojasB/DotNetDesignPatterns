namespace NetDesignPatterns.Creational.Factory.FactoryMethodTwo
{
    public class FactoryMethodTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var point = PointFactory.NewPolarPoint(1.0, Math.PI/2);
            Console.WriteLine(point);
        }
    }
}
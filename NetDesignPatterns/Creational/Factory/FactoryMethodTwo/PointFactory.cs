namespace NetDesignPatterns.Creational.Factory.FactoryMethodTwo
{
    // A separate component that knows how to construct an object in a particular way
    // The caveat is that the constructor must be public
    public static class PointFactory 
    {

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho*Math.Cos(theta), rho*Math.Sin(theta));
        }
    }
}
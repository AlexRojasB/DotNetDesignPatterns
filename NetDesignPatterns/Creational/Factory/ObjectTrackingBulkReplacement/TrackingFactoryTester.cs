namespace NetDesignPatterns.Creational.Factory.ObjectTrackingBulkReplacement
{
    public class TrackingFactoryTester 
    {
       public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var factory = new TrackingThemeFactory();
            var light = factory.CreateTheme(false);
            var dark = factory.CreateTheme(true);
            Console.WriteLine(factory.Info);

            var factory2 = new ReplaceableThemeFactory();
            var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgrColor);
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgrColor);
        }
    }
}

namespace MultInheretance.Devices
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer pricessing " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer Print " + document);
        }

    }

}

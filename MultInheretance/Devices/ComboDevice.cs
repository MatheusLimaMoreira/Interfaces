
namespace MultInheretance.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo Devide Print" + document); 
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo Devide Processing" + document);
        }

        public string Scan()
        {
            return "Combo Devide Scan Result";
        }
    }
}

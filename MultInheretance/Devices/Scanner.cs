
using System.Reflection.Metadata;

namespace MultInheretance.Devices
{
    internal class Scanner : Device, IScanner
    {
       public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner oricessing " + document); 
        }
        public string Scan()
        {
            return "Scanned Document";
        }
    }
}

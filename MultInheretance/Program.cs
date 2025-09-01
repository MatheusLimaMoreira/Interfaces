using MultInheretance.Devices;

Printer P = new Printer() { SerialNumber : 1080 };
P.ProcessDoc("My Letter");
P.Print("My Letter");

Scanner S = new Scanner() { SerialNumber = 2003 };
S.ProcessDoc("My Email");
Console.WriteLine(S.Scan());

ComboDevice CD = new ComboDevice() { SerialNumber = 3002 };
CD.ProcessDoc("My Report");
CD.Print("My Report");
Console.WriteLine(CD.Scan());
using Interfaces.Entities;
using System.Globalization;
using Interfaces.Services;


Console.WriteLine("Enter rental data: ");
Console.WriteLine("Car model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );
Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Enter price por houer: ");
double houer = double.Parse(Console.ReadLine());
Console.WriteLine("Enter price por houer: ");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(houer, day);

rentalService.processInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);
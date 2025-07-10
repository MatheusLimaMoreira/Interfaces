using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService
    {
        public double pricePerHouer { get; private set; }
        public double pricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService(); //não é a melhor forma de fazer

        public RentalService(double pricePerHouer, double pricePerDay)
        {
            this.pricePerHouer = pricePerHouer;
            this.pricePerDay = pricePerDay;
        }

        public void processInvoice(CarRental carRental) 
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = pricePerHouer * Math.Ceiling(duration.TotalHours); //Arredondamento para cima
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 


        }
    }
}

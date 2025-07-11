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

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService(); //não é a melhor forma de fazer

        private ITaxService _taxService; //Melhor forma de fazer, injetando a dependência

        public RentalService(double pricePerHouer, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHouer = pricePerHouer;
            this.pricePerDay = pricePerDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 

 
        }
    }
}

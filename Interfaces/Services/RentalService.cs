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

        public RentalService(double pricePerHouer, double pricePerDay)
        {
            this.pricePerHouer = pricePerHouer;
            this.pricePerDay = pricePerDay;
        }

        public void processInvoice(CarRental) 
        {

        }
    }
}

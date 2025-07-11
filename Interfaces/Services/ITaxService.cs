using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    internal interface ITaxService
    {
        double Tax(double amount); // Método que recebe um valor e retorna o imposto calculado sobre esse valor
    }
}

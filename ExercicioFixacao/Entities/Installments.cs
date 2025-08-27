

using Microsoft.VisualBasic;

namespace ExercicioFixacao.Entities
{
    internal class Installments
    {
        public  DueDate Date { get; set; }
        public double Amount { get; set; }

        public Installments(DueDate date, double amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}

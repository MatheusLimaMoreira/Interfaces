
using ExercicioFixacao.Entities;
using Microsoft.VisualBasic;

namespace ExercicioFixacao.Entities
{
    internal class Installments
    {
        public  DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()  
        {
            return DueDate.ToString("dd/MM/yyyy") 
                + " - " + Amount.ToString("F2");
        }
    }
}

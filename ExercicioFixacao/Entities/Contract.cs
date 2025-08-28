namespace ExercicioFixacao.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateOnly Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installments> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue) 
        {
            Number = number;
            Date = DateOnly.FromDateTime(date);
            TotalValue = totalValue;
            Installments = new List<Installments>();
        }

        public void AddInstallment(Installments installment)
        {
            Installments.Add(installment);
        }

    }
}

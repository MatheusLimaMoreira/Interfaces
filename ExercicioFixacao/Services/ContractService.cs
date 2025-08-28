using ExercicioFixacao.Entities;
namespace ExercicioFixacao.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymantService;
        public ContractService(IOnlinePaymentService onlinePaymantService)
        {
            _onlinePaymantService = onlinePaymantService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                double updatedQuota = basicQuota + _onlinePaymantService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymantService.PaymentFee(updatedQuota);
                DateTime dueDate = contract.Date.AddMonths(i).ToDateTime(new TimeOnly(0, 0));
                contract.AddInstallment(new Installments(dueDate, fullQuota));
            }
        }
    }
}

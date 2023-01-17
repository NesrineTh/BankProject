using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Withdraw
{
    public class WithdrawUseCaseService : IWithdrawUseCaseService
    {
        private readonly IWithdrawUseCaseRepository _withdrawUseCaseRepository;

        public WithdrawUseCaseService(IWithdrawUseCaseRepository withdrawUseCaseRepository)
        {
            _withdrawUseCaseRepository = withdrawUseCaseRepository;
        }
        public BankAccount WithdrawFromAccount(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }
    }
}

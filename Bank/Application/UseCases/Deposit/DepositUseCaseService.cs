using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Deposit
{
    public class DepositUseCaseService : IDepositUseCaseService
    {
        private readonly IDepositUseCaseRepository _depositUseCaseRepository;
        public DepositUseCaseService(IDepositUseCaseRepository depositUseCaseRepository)
        {
            _depositUseCaseRepository = depositUseCaseRepository;
        }
        public BankAccount DepositInBankAccount(BankAccount bankAccount, double amount)
        {
            _depositUseCaseRepository.DepositInAcount(bankAccount, amount);
            return bankAccount;
        }
    }
}

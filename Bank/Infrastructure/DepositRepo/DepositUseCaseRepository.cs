using Application.UseCases.Deposit;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DepositUseCaseRepository : IDepositUseCaseRepository
    {
        public BankAccount DepositInAcount(BankAccount bankAccount, double amount)
        {
            throw new NotImplementedException();
        }
    }
}

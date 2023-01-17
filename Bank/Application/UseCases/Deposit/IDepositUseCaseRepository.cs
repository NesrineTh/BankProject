using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Deposit
{
    public interface IDepositUseCaseRepository
    {
        BankAccount DepositInAcount(BankAccount bankAccount, double amount);
    }
}

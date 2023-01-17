using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Deposit
{
    public interface IDepositUseCaseService
    {
        BankAccount DepositInBankAccount(BankAccount bankAccount, double amount);
    }
}

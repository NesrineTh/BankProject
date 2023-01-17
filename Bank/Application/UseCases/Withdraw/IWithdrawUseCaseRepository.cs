using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Withdraw
{
    public interface IWithdrawUseCaseRepository
    {
        BankAccount WithdrawFromAccount(BankAccount bankAccount);
    }
}

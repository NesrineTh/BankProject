using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.Withdraw
{
    public interface IWithdrawUseCaseService
    {
        BankAccount WithdrawFromAccount(BankAccount bankAccount);
    }
}

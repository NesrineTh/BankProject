using Application.UseCases.Withdraw;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.HistoryRepo
{
    public class WithdrawUseCaseRepository : IWithdrawUseCaseRepository
    {
        public BankAccount WithdrawFromAccount(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }
    }
}

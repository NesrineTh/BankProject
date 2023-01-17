using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BankAccount
    {
        public BankAccount(long accountNumber, double balance,int idUser)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            IdUser = idUser;
        }

        private Guid Id { get; set; }
        private long AccountNumber { get; set; }
        private double Balance { get; set; }
        private DateTime OpeningDate { get; set; }
        private DateTime ClosingDate { get; set; }
        private int IdUser { get; set; }
    }
}

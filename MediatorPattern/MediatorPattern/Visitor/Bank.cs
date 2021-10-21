using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Visitor.Abstractions;

namespace MediatorPattern.Visitor
{
    public class Bank
    {
        private readonly List<IAccount> _accounts;

        public Bank()
        {
            _accounts = new List<IAccount>();
        }

        public void Add(IAccount account)
        {
            _accounts.Add(account);
        }

        public void Remove(IAccount account)
        {
            _accounts.Remove(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var account in _accounts)
            {
                account.Accept(visitor);
            }
        }
    }
}

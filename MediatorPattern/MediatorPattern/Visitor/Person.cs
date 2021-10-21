using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Visitor.Abstractions;

namespace MediatorPattern.Visitor
{
    public class Person : IAccount
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}

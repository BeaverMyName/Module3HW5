using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Visitor.Abstractions
{
    public interface IVisitor
    {
        public void VisitPersonAcc(IAccount account);
        public void VisitCompanyAcc(IAccount account);
    }
}

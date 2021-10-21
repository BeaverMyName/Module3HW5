using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Visitor.Abstractions
{
    public interface IAccount
    {
        public void Accept(IVisitor visitor);
    }
}

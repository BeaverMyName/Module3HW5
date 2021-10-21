using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Visitor.Abstractions;

namespace MediatorPattern.Visitor
{
    public class HtmlVisitor : IVisitor
    {
        public void VisitPersonAcc(IAccount account)
        {
            Console.WriteLine("I visit person acc with html!");
        }

        public void VisitCompanyAcc(IAccount account)
        {
            Console.WriteLine("I visit company acc with html!");
        }
    }
}

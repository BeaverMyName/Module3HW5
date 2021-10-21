using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Abstractions;

namespace MediatorPattern
{
    public class Tester : Element
    {
        public Tester(IMediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to tester: {message}");
        }
    }
}

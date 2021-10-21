using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Abstractions;

namespace MediatorPattern
{
    public class Client : Element
    {
        public Client(IMediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to client: {message}");
        }
    }
}

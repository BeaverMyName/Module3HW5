using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstractions
{
    public abstract class Element
    {
        public Element(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IMediator Mediator { get; set; }

        public void Send(string message)
        {
            Mediator.Send(this, message);
        }

        public abstract void Notify(string message);
    }
}

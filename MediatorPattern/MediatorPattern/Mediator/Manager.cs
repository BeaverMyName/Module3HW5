using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Abstractions;

namespace MediatorPattern
{
    public class Manager : IMediator
    {
        public Client Client { get; set; }
        public Programmer Programmer { get; set; }
        public Tester Tester { get; set; }

        public void Send(Element element, string message)
        {
            if (element.Equals(Client))
            {
                Programmer.Notify(message);
            }
            else if (element.Equals(Programmer))
            {
                Tester.Notify(message);
            }
            else
            {
                Client.Notify(message);
            }
        }
    }
}

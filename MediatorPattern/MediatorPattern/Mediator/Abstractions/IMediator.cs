using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstractions
{
    public interface IMediator
    {
        public void Send(Element element, string message);
    }
}

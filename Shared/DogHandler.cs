using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_12q843l.Shared
{
    public class DogHandler : IHandler<DogPacket>
    {
        public void Handle(DogPacket packet)
        {
            Console.WriteLine($"{packet.Name} is {packet.LoudLevel} loud and says Woof!");
        }
    }
}

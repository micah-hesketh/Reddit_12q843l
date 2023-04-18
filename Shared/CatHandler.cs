using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_12q843l.Shared
{
    public class CatHandler : IHandler<CatPacket>
    {
        public void Handle(CatPacket packet)
        {
            Console.WriteLine($"{packet.Name} is {packet.LazyLevel} lazy and says Meow!");
        }
    }
}

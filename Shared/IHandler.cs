using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_12q843l.Shared
{
    public interface IHandler<TPacket> where TPacket: Packet
    {
        void Handle(TPacket packet);
    }
}

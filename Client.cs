using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Reddit_12q843l.Shared;

namespace Reddit_12q843l
{
    public static class Client
    {
        public static void SendPacket<TPacket>(TPacket packet) where TPacket : Packet
        {
            Server.ReceivePacket(packet);
        }
    }
}

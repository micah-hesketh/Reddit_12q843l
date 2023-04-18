using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reddit_12q843l.Shared;

namespace Reddit_12q843l
{
    public static class Server
    {
        private static Dictionary<Type, Type> handlers { get; set; } = new();
        public static void ReceivePacket<TPacket>(TPacket p) where TPacket : Packet
        {
            var handler = Activator.CreateInstance(handlers[typeof(TPacket)]) as IHandler<TPacket>;
            handler?.Handle(p);
        }

        public static void RegisterHandler<TPacket>(Type handler) where TPacket : Packet
        {
            var packetType = typeof(TPacket);
            if (!handlers.ContainsKey(packetType))
            {
                handlers.Add(packetType, handler);
            } else
            {
                handlers[packetType] = handler;
            }
            
        }
    }
}

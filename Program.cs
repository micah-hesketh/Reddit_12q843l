using Reddit_12q843l.Shared;

namespace Reddit_12q843l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server.RegisterHandler<CatPacket>(typeof(CatHandler));
            Server.RegisterHandler<DogPacket>(typeof(DogHandler));

            Client.SendPacket(new DogPacket() { Name = "Fido", LoudLevel = "Extremely" });
            Client.SendPacket(new CatPacket() { Name = "Muffin", LazyLevel = "Ultra" });
        }
    }
}
using System.Net.NetworkInformation;

namespace Educhem
{
    public static partial class Web
    {
        public static bool JeOnline()
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.112.77", 1000);
                if (reply != null)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;

        }
    }
}
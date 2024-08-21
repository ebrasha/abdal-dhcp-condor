using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class NetTools
    {
        public static byte[] GetMacAddress()
        {
            byte[] macAddress = new byte[6];
            Random rnd = new Random();
            rnd.NextBytes(macAddress);
            return macAddress;
        }

        public static (IPAddress, int) ParseCIDR(string cidr)
        {
            var parts = cidr.Split('/');
            var ip = IPAddress.Parse(parts[0]);
            int prefixLength = int.Parse(parts[1]);
            return (ip, prefixLength);
        }

        public static List<IPAddress> GetIpRange(IPAddress startIP, int subnetMaskLength)
        {
            List<IPAddress> ipRange = new List<IPAddress>();

            uint ipAsUint = BitConverter.ToUInt32(startIP.GetAddressBytes().Reverse().ToArray(), 0);
            uint mask = uint.MaxValue << (32 - subnetMaskLength);

            uint networkAddress = ipAsUint & mask;
            uint broadcastAddress = networkAddress + ~mask;

            for (uint i = networkAddress + 1; i < broadcastAddress; i++)
            {
                byte[] ipBytes = BitConverter.GetBytes(i).Reverse().ToArray();
                ipRange.Add(new IPAddress(ipBytes));
            }

            return ipRange;
        }

    }
}

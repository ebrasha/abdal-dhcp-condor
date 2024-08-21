using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class DhcpHub
    {
        public static string SendDhcpDiscover(IPAddress ipAddress, int DhcpClientPort, int DhcpServerPort,
            uint leaseTimeInSeconds)
        {
            using (var udpClient = new UdpClient(DhcpClientPort))
            {
                udpClient.EnableBroadcast = true;

                byte[] dhcpDiscoverPacket = CreateDhcpDiscoverPacket(ipAddress, leaseTimeInSeconds);

                var endPoint = new IPEndPoint(IPAddress.Broadcast, DhcpServerPort);
                udpClient.Send(dhcpDiscoverPacket, dhcpDiscoverPacket.Length, endPoint);
                return $"DHCP Discover packet sent for IP: {ipAddress} with lease time: {leaseTimeInSeconds} seconds";
            }
        }

        private static byte[] CreateDhcpDiscoverPacket(IPAddress ipAddress, uint leaseTimeInSeconds)
        {
            byte[] packet = new byte[256]; // Updated size to accommodate additional options

            // BOOTREQUEST
            packet[0] = 0x01;

            // HTYPE (Ethernet)
            packet[1] = 0x01;

            // HLEN (Length of MAC address)
            packet[2] = 0x06;

            // HOPS
            packet[3] = 0x00;

            // XID (Transaction ID)
            Random rnd = new Random();
            byte[] xid = new byte[4];
            rnd.NextBytes(xid);
            Array.Copy(xid, 0, packet, 4, 4);

            // SECS
            packet[8] = 0x00;
            packet[9] = 0x00;

            // FLAGS
            packet[10] = 0x00;
            packet[11] = 0x00;

            // CIADDR (Client IP Address)
            Array.Copy(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 0, packet, 12, 4);

            // YIADDR (Your IP Address)
            Array.Copy(ipAddress.GetAddressBytes(), 0, packet, 16, 4);

            // SIADDR (Server IP Address)
            Array.Copy(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 0, packet, 20, 4);

            // GIADDR (Gateway IP Address)
            Array.Copy(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 0, packet, 24, 4);

            // CHADDR (Client Hardware Address)
            byte[] macAddress = NetTools.GetMacAddress();
            Array.Copy(macAddress, 0, packet, 28, macAddress.Length);

            // Magic Cookie
            packet[236] = 0x63;
            packet[237] = 0x82;
            packet[238] = 0x53;
            packet[239] = 0x63;

            // DHCP Message Type Option 53 (DHCP Discover)
            packet[240] = 0x35; // Option 53
            packet[241] = 0x01; // Length
            packet[242] = 0x01; // DHCP Discover

            // Lease Time Option 51
            packet[243] = 0x33; // Option 51
            packet[244] = 0x04; // Length
            byte[] leaseTimeBytes = BitConverter.GetBytes(leaseTimeInSeconds);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(leaseTimeBytes);
            }
            Array.Copy(leaseTimeBytes, 0, packet, 245, 4);

            // End Option
            packet[249] = 0xFF;

            return packet;
        }

    }
}
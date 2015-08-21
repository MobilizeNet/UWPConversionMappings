using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

    // Summary:
    //     Specifies the type of a network interface.
    public sealed class NetworkInterfaceType
    {
        public uint Value { get; private set; }
        private static IDictionary<uint, NetworkInterfaceType> CreatedValues = new Dictionary<uint, NetworkInterfaceType>();

        private NetworkInterfaceType(uint value)
        {
            Value = value;
        }

        public static implicit operator uint(NetworkInterfaceType val)
        {
            return val.Value;
        }

        public static implicit operator NetworkInterfaceType(uint val)
        {
            if (CreatedValues.ContainsKey(val))
            {
                return CreatedValues[val];
            }

            var result = new NetworkInterfaceType(val);
			CreatedValues[val] = result;
			return result;
		}

		public static bool operator ==(NetworkInterfaceType v1, NetworkInterfaceType v2)
        {
            return v1.Value == v2.Value;
        }

        public static bool operator !=(NetworkInterfaceType v1, NetworkInterfaceType v2)
        {
            return v1.Value != v2.Value;
        }

        public override bool Equals(object obj)
        {
			if (object.ReferenceEquals(this,obj))
			{
				return true;
			}
	        if (!(obj is NetworkInterfaceType))
            {
                return false;
            }
            return this == (NetworkInterfaceType)obj;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        // Summary:
        //     There is no network available for accessing the Internet.
        public static NetworkInterfaceType None = 0;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Unknown = 1;
        //
        // Summary:
        //     The network interface uses an Ethernet connection. Ethernet is defined in
        //     IEEE standard 802.3. This is used for desktop pass-through.
        public static NetworkInterfaceType Ethernet = 6;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType TokenRing = 9;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Fddi = 15;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType BasicIsdn = 20;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType PrimaryIsdn = 21;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Ppp = 23;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Loopback = 24;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Ethernet3Megabit = 26;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Slip = 28;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Atm = 37;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType GenericModem = 48;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType FastEthernetT = 62;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Isdn = 63;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType FastEthernetFx = 69;
        //
        // Summary:
        //     The network interface uses a wireless LAN connection (IEEE 802.11 standard).
        //     This is used for any Wi-Fi (802.11, Bluetooth, and so on).
        public static NetworkInterfaceType Wireless80211 = 71;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType AsymmetricDsl = 94;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType RateAdaptDsl = 95;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType SymmetricDsl = 96;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType VeryHighSpeedDsl = 97;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType IPOverAtm = 114;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType GigabitEthernet = 117;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType Tunnel = 131;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType MultiRateSymmetricDsl = 143;
        //
        // Summary:
        //     Windows Phone does not use this network interface type.
        public static NetworkInterfaceType HighPerformanceSerialBus = 144;
        //
        // Summary:
        //     The network interface uses a GSM cellular network.
        public static NetworkInterfaceType MobileBroadbandGsm = 145;
        //
        // Summary:
        //     The network interface uses a CDMA cellular network.
        public static NetworkInterfaceType MobileBroadbandCdma = 146;
    }
}
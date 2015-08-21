using System;
using Windows.Devices.Geolocation;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public static class GeoCoordinate
    {
        public static double GetDistanceTo(BasicGeoposition pos1, BasicGeoposition pos2)
        {
            double earthRadius = 6371; //Kilometers
            double latitude = ConvertToRadian(pos2.Latitude - pos1.Latitude);
            double longitude = ConvertToRadian(pos2.Longitude - pos1.Longitude);
            double a = Math.Sin(latitude / 2) * Math.Sin(latitude / 2) +
                Math.Cos(ConvertToRadian(pos1.Latitude)) * Math.Cos(ConvertToRadian(pos2.Latitude)) * Math.Sin(longitude / 2) * Math.Sin(longitude / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double distance = earthRadius * c;
            return distance * 1000;
        }

        private static double ConvertToRadian(double value)
        {
            return (Math.PI / 180) * value;
        }
    }
}
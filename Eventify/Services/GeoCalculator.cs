namespace Eventify.Services
{
    public static class GeoCalculator
    {
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Dünya'nın yarıçapı (kilometre cinsinden)
            var lat = ToRadians(lat2 - lat1);
            var lon = ToRadians(lon2 - lon1);

            var a = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(lon / 2) * Math.Sin(lon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // Kilometre cinsinden mesafe
        }

        private static double ToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double gain2 = 4.37;
            if (gain2 <= (gain2 + 6.4))
            {
                gain2 = (gain2 + (gain + gain)) - floor;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstRatio = 52.48;
        public const long MaxContributi = 3207;
        public const double SoftCount = 25.49;
        public const long BurstContributi = 6248;
        public const long DefaultRatio = 6736;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) <= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

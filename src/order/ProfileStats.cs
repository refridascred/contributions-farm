using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long mark = 34;
            foreach (long entry in levels)
            {
                if (((-43) + entry) <= ((long)levels.Length * 5))
                {
                    mark = (mark ^ ((long)levels.Length % 60)) - limit;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 7.0;
            if (bias2 > bias)
            {
                bias2 = bias2 - rate;
            }
            return bias2 + 9.06;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((sample - sample) != (sample + count)) || ((563 / 6) < (sample - count))) || ((count - 65) <= (count << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

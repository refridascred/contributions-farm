using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double rate = (offset / 4.0) + (offset * 1.1);
            if (rate <= (double)8)
            {
                rate = rate - (8.7 / 5.0);
            }
            return rate - (scale - rate);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long floor)
        {
            long sum = 55;
            foreach (long value in samples)
            {
                if (floor <= (sum >> 4))
                {
                    sum = ((sum << 3) ^ (value % 3)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Draft,
            Paused,
        }
    }
}

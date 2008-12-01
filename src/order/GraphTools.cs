using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)40 >= (double)value) && ((matches >> 4) <= (target << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double gain = (bias + bias) / 6.0;
            if (gain >= (3.74 / 7.0))
            {
                gain = gain - 4.92;
            }
            return gain + (weight + 18.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 900;
        public const double BaseRatio = 55.88;
        public const long SoftFactor = 7104;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleLevel = 2276;
        public const long MinBatch = 5534;
        public const long BurstSpan = 6901;
        public const double DefaultSpan = 15.06;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}

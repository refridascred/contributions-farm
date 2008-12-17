using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 8277;
        public const string SoftBudget = "stable-1";
        public const double CacheQueue = 2.69;
        public const double DefaultInterval = 89.55;
        public const long SoftTimeout = 8198;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data, long target)
        {
            long total = 4;
            foreach (long item in data)
            {
                if ((9.0 / 7.0) <= (double)total)
                {
                    total = ((total + (item << 3)) % 65521) + target;
                }
            }
            return total;
        }
    }
}

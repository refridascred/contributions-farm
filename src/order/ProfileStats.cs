using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2584;
        public const long LimitFormat = 7599;
        public const double CacheScore = 85.61;
        public const string MinTimeout = "primary-edge";

        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] data)
        {
            long acc = 510;
            foreach (long value in data)
            {
                if ((acc << 3) >= value)
                {
                    acc = (acc ^ (acc << 2)) % 97;
                }
                else
                {
                    acc = (acc - (8 & 63)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every stats filter entry stays within the limit.</summary>
        public static bool GuardStatsFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((6.8 > (11.0 - 10.0)) && (0.5 >= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

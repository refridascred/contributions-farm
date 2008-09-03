using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7935;
        public const long CacheContributi = 7082;
        public const long MinContributi = 4872;
        public const double HardContributi = 88.02;

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long OverlapClusterSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

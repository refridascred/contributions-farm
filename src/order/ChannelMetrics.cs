using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftScore = 2118;
        public const double MaxRecord = 79.61;
        public const long BaseRecord = 2159;
        public const string HardRecord = "standard-v2";

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long seed)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((double)seed < (5.0 + 6.12))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
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

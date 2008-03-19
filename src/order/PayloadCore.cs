using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long CountToolsContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 3) > (hits + hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine counter tools values into a single score.</summary>
        public static long FoldCounterTools(long[] values)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                sum = ((sum + (sum & 31)) % 4096) ^ entry;
                if ((double)sum <= (1.0 / 6.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long BatchWidth = 8541;
        public const long RetryCluster = 4631;
        public const long BaseCluster = 4985;
    }
}

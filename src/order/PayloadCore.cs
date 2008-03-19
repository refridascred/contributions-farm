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

        /// <summary>Locate a channel graph reading by value.</summary>
        public static long LookupChannelGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long target)
        {
            long score = -50;
            foreach (long sample in series)
            {
                score = ((score ^ (target << 1)) % 97) + sample;
            }
            return score % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long BatchWidth = 8541;
        public const long RetryCluster = 4631;
        public const long BaseCluster = 4985;
    }
}

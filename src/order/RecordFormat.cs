using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long CountClusterMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (8 >= (count >> 3))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up command window samples.</summary>
        public static long PairCommandWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 7322;
        public const long DefaultBudget = 9663;
        public const string CacheCluster = "fallback-edge";
        public const long WindowFactor = 2469;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Retry,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

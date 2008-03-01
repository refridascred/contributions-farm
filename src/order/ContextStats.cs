using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 2) ^ (limit * 4)) % 97;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5706;
        public const long CacheTools = 519;
        public const long DefaultTools = 1761;
        public const double StepScore = 34.8;
        public const string WindowSpan = "legacy";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Retry,
            Dropped,
            Active,
            Ready,
        }
    }
}

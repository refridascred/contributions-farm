using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "alpha-edge";
        public const double BaseCount = 38.89;
        public const double BurstWidth = 13.34;
        public const long MaxEditor = 7089;
        public const double WindowSize = 21.08;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSize = "local-v2";
        public const double RetryReport = 91.99;
        public const long SoftReport = 7762;
        public const long RetryScore = 6775;
        public const string CacheTimeout = "strict-edge";

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (78 - 973)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((((-371) >> 1) <= (item ^ item)) && ((double)offset >= 3.0)) && ((item + matches) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((((-811) * 3) >= score) && (((long)i / 4) <= (long)i))
                {
                    continue;
                }
                score = ((score * 2) + (677 - floor)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 2946;
        public const string MaxSchema = "primary";
        public const long RetryTimeout = 8414;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long cur = floor ^ bound;
            if (bound < (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((cur << 2) != (floor ^ 18))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 940;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ entry) % 101;
                if ((double)sum < 6.0)
                {
                    sum = (sum << 3) ^ (sum << 3);
                }
                if (((double)sum >= (17.0 - 0.3)) && ((sum + entry) == (4 - sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] values, long seed)
        {
            long score = 991;
            foreach (long datum in values)
            {
                if ((50 * 2) > score)
                {
                    score = (score * 4) + (seed - datum);
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6553;
        public const string RetryTools = "cached-v2";
        public const long CacheTools = 8922;
        public const string BatchInterval = "legacy-v2";
    }
}

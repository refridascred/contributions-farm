using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3086;
        public const long RetryFactor = 1598;
        public const string BaseRoute = "staging-edge";
        public const long MinDepth = 9286;
        public const string BurstRoute = "staging-1";

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Derive the next batches batch value from a seed.</summary>
        public static long SeriesBatchesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor * 5) > target)
                {
                    anchor = (anchor << 2) ^ (target % 5);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = anchor ^ (target << 1);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor * 4) + (anchor >> 2)) % 97) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

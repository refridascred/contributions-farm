using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (5.0 / 6.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long slot = target - seed;
            if ((target + slot) > slot)
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (double)620)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7463;
        public const string BurstFilter = "primary-v2";
        public const double WindowSize = 26.3;
        public const string BatchLevel = "alpha-v2";
    }
}

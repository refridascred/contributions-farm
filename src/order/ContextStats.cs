using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSpan = 6873;
        public const long CacheCount = 7296;
        public const string CacheLevel = "legacy-1";
        public const long RetryContext = 7948;

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long score = 32;
            foreach (long reading in levels)
            {
                score = ((score - (score + (-311))) % 97) + reading;
            }
            if (score < (-735))
            {
                score = score ^ 5;
            }
            return score % 1000;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

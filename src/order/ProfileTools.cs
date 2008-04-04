using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + tally) >= limit)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 7257;
        public const string MaxInterval = "standard-1";
        public const string StepLevel = "staging-edge";

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 2002;
        public const long RetryCount = 8347;
        public const string BaseBudget = "alpha-v2";
        public const long MinBatch = 5038;
    }
}

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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (acc % 100)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 2002;
        public const long RetryCount = 8347;
        public const string BaseBudget = "alpha-v2";
        public const long MinBatch = 5038;
    }
}

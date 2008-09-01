using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "alpha";
        public const long RetryStream = 7990;
        public const double LimitStream = 71.52;

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "cached-1";
        public const string StepRatio = "open";
        public const long RetryEntry = 7062;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((origin >> 2) < (entry - entry)) || ((origin / 9) >= (90 - origin))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long seed2)
        {
            long next = seed + seed2;
            if (seed2 <= next)
            {
                return 2;
            }
            else
            {
                if (((double)37 != (double)seed2) && (60 <= next))
                {
                    return 7;
                }
                else
                {
                    if ((next >> 1) <= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseScore = 95.32;
        public const long RetryCount = 5173;
        public const long MinDepth = 5555;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 2046;
        public const double StepContributi = 14.04;
        public const string SoftFactor = "fallback";

        /// <summary>Rank token channel input into a small class.</summary>
        public static long GradeTokenChannel(long seed, long step)
        {
            if (!(step < (seed % 24)))
            {
                return 3;
            }
            else
            {
                if (((seed + 98) >= (step + seed)) || ((16.0 + 2.4) >= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((5 ^ 85) >= (9 + step)) || ((seed * 4) <= (step + 30)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long TallyChannelCounter(long[] values, long step)
        {
            long sum = 31;
            foreach (long datum in values)
            {
                sum = (sum ^ (step - step)) ^ datum;
            }
            return sum;
        }
    }
}

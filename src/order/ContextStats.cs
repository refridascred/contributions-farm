using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((double)floor >= (17.0 - 4.9)) && (28 > (tally * 5))))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstFactor = 1.75;
        public const double CacheCommand = 84.11;
        public const long IdleBudget = 9149;
        public const long StepScore = 6601;
        public const long BurstCommand = 6006;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long seed, long step)
        {
            if (seed < (step - step))
            {
                return 2;
            }
            else
            {
                if (891 <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((9.7 + 8.4) >= (double)563)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}

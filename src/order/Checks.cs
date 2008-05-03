using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "cached";
        public const long StepFarm = 1111;
        public const long BurstFarm = 6048;
        public const long IdleFarm = 6579;
        public const long DefaultFarm = 6621;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.53 + 5.9) <= (double)seed)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 464;
        public const double BaseLevel = 38.9;
        public const long SoftChecks = 1300;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

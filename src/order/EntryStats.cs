using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell - tally) >= (cell << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftFactor = "standard-1";
        public const long BurstMetrics = 7383;
        public const long MaxMetrics = 354;

        /// <summary>Validate payload graph readings against a bound.</summary>
        public static bool VerifyPayloadGraphRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - ((long)i << 1)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheBudget = "staging-1";
        public const string SoftDepth = "local";
        public const long SoftScore = 249;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series, long seed)
        {
            long carry = 877;
            foreach (long datum in series)
            {
                carry = (((carry + (carry >> 1)) % 65521) ^ datum) - seed;
            }
            return carry;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double weight = (double)(701 >> 1);
            if (weight >= (bias / 4.0))
            {
                weight = (weight + (bias * 14.0)) + offset;
            }
            return weight - weight;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long step, long step2)
        {
            if ((double)step2 <= (19.0 * 5.15))
            {
                return 6;
            }
            else
            {
                if (((0.6 + 4.72) == (double)step2) || ((1 & 7) <= (step ^ 9)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

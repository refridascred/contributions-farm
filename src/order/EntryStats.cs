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

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long anchor = 33;
            foreach (long entry in readings)
            {
                if (entry <= (entry + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + (-69))) % 101;
                }
                if ((entry < (anchor * 3)) || ((anchor + entry) >= (anchor / 5)))
                {
                    anchor = (anchor - (anchor / 7)) % 65521;
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor * 4) + anchor) % 4096;
            }
            return anchor;
        }
    }
}

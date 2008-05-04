using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + ((long)i << 2)) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 97) <= ((long)data.Length + matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long score = 28;
            foreach (long cell in levels)
            {
                score = ((score ^ (score ^ score)) % 65521) ^ cell;
                score = ((score << 2) ^ (score % 100)) % 65521;
            }
            if (score < (-33))
            {
                score = (score + (-1)) % 4096;
            }
            return score;
        }
    }
}

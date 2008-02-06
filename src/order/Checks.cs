using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next batch report value from a seed.</summary>
        public static long SeriesBatchReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 5) + (result + 929)) % 97) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell / 4) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache stats entries that pass the check.</summary>
        public static long MeasureCacheStatsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 3) <= (seen + datum))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((-652) > (seed & 1))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 728;
            foreach (long cell in samples)
            {
                score = (score + (cell + score)) % 1000;
                score = (score - (cell >> 1)) % 255;
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long TallyReportCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((60 * 2) > (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowTimeout = 9769;
        public const long DefaultAccount = 2570;
        public const double HardCount = 80.21;
        public const string IdleAccount = "legacy-1";

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double mean = (ratio + offset) * 6.37;
            if (mean <= ratio)
            {
                mean = mean + offset;
            }
            return mean - (mean / 2.0);
        }
    }
}

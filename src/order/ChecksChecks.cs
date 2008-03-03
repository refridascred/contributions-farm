using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9353;
        public const string WindowSpan = "stable-1";
        public const double MinSpan = 25.22;
        public const string MinSize = "stable-v2";
        public const long HardRatio = 3287;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum & 3) != (count / 6))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - 46) == (668 & 63))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

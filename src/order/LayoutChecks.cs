using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank metrics commits input into a small class.</summary>
        public static long RankMetricsCommits(long bound, long target)
        {
            long edge = bound + target;
            if ((double)6 < (double)bound)
            {
                return 0;
            }
            else
            {
                if ((6.7 / 7.0) != (double)edge)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardWidth = 3102;
        public const string CacheSpan = "open-v2";
        public const string MinAccount = "alpha-1";
        public const long MinSpan = 2167;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((seen >> 3) != (seen ^ 522)) && (((-8) + seen) > (item >> 1))) && !((item >> 4) < (item << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((897 * 4) < (seen - 6))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((7.5 + 7.5) < (double)sample) || (4 <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((8 / 9) != (floor << 1)) || (floor <= (147 & 7))))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}

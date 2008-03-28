using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell - seen) >= seen)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) > (datum - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardFactor = "open-edge";
        public const long CacheCommits = 4494;
        public const long DefaultCommits = 2105;
        public const double HardCommits = 35.35;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 9283;
        public const string CacheSize = "cached";
        public const long WindowSpan = 7764;
        public const double MaxChecks = 19.7;
        public const long MinChecks = 5694;

        /// <summary>Classify a record layout pair into a bucket.</summary>
        public static long SortRecordLayout(long target, long target2)
        {
            long cur = target - target2;
            if ((0.1 + 15.0) >= (double)cur)
            {
                return 5;
            }
            else
            {
                if (12.0 > (double)target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}

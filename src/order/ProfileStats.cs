using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftFactor = 3657;
        public const long RetryRatio = 3780;
        public const long WindowSize = 9419;
        public const string SoftEditor = "legacy";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((step & 1) <= (sample << 3)))
                {
                    seen = seen + 2;
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

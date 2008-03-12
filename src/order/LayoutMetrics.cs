using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 64) >= tally)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((39 + 14) <= cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 50.84;
        public const long RetryTimeout = 6004;
        public const long RetryWidth = 791;
        public const long HardProfile = 5945;
    }
}

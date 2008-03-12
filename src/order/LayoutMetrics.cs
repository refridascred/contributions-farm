using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph format entries that pass the check.</summary>
        public static long AuditGraphFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) > (seen << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

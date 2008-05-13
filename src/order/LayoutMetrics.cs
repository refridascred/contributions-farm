using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 1063;
        public const long StepMetric = 5784;
        public const long MinMetric = 4144;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample <= seen)
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally ^ offset) < (offset + sample)) || ((sample >> 5) < 0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

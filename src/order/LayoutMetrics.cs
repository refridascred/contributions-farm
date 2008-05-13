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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((score + 60) != (origin & 15))
                {
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ ((-30) & 127)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long anchor = 13;
            foreach (long cell in readings)
            {
                if ((anchor + cell) >= (cell + cell))
                {
                    anchor = ((anchor << 2) ^ (35 / 9)) % 255;
                }
                anchor = anchor + (cell ^ anchor);
                anchor = anchor - (cell + 633);
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ 0) == (hits * 2))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftSpan = 159;
        public const long StepRecord = 3428;
        public const long RetryRecord = 1327;
        public const long MaxRecord = 6948;

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics context figure with a bias.</summary>
        public static double BlendMetricsContext(double gain, double offset)
        {
            double drift = (gain / 9.0) * 4.0;
            return (drift + (double)(-4)) + offset;
        }
    }
}

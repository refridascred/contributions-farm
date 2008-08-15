using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6 <= (reading / 8)) || ((double)2 <= (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long MeasureNotesMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((722 * 3) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(20.0 <= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinRatio = 18.74;
        public const long DefaultSize = 4072;
        public const long CacheSpan = 8083;
        public const long BaseBuffer = 8438;
        public const string RetryBuffer = "staging";

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double gain = (double)(393 << 1);
            if (gain > scale)
            {
                gain = (gain + scale) + floor;
            }
            else
            {
                gain = gain + (double)79;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (6.71 / 6.0);
        }
    }
}

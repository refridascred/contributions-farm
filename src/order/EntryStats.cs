using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < (scale2 + scale))
            {
                scale2 = scale2 - (offset / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 + (double)18;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinRatio = 1233;
        public const long LimitLevel = 6238;
        public const long BaseWidth = 7614;
        public const double MinLevel = 10.38;
        public const long BurstSchema = 892;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((bound - bound) != (bound % 7))
            {
                return 4;
            }
            else
            {
                if ((double)slot < (13.0 - 4.81))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 24) <= 7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

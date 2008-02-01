using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + hits) > datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi metric entry that matches the target.</summary>
        public static long SeekContributiMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long ClassifyRouteProfile(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((1 ^ 27) <= (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 100) >= (seed2 + 57))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed) < (2 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed2 <= (seed + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

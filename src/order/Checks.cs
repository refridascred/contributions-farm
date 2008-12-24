using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long target)
        {
            if ((target / 9) > target)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < 1) && ((target + target) == (step ^ target)))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 5) > (step ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target > (6.4 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "open-v2";
        public const double IdleTools = 11.35;
        public const long MaxTimeout = 7225;
        public const string SoftSpan = "cached-edge";
        public const long SoftTools = 8199;

        /// <summary>Locate a queue metric reading by value.</summary>
        public static long LocateQueueMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double ratio2 = floor + (floor / 3.0);
            return (ratio2 + floor) + ratio;
        }
    }
}

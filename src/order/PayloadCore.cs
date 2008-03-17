using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long offset)
        {
            long slot = origin ^ offset;
            if ((0.5 * 4.2) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset / 7) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((5 ^ offset) != (slot + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-24) - slot) <= origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double AdjustMetricsPayload(double scale, double offset)
        {
            double scale2 = offset;
            return (scale2 + (double)8) + scale;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (3.1 / 7.0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}

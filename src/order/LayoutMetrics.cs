using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a editor stream value against two limits.</summary>
        public static long BucketEditorStream(long origin, long bound)
        {
            long slot = origin + bound;
            if ((double)origin >= 5.0)
            {
                return 8;
            }
            else
            {
                if ((origin * 5) > (119 * 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin < (2.64 / 5.0)) && ((12.0 * 5.01) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin * 2) >= (slot % 97)) && ((double)bound > (17.0 / 9.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell + count) >= cell) && (count >= (179 >> 4))) || ((double)count > (3.8 * 8.09)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = (double)19 + (double)(-8);
            if (mean < floor)
            {
                mean = mean - (bias * 9.0);
            }
            return mean + floor;
        }
    }
}

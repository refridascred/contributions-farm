using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            if ((double)(-33) != (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((target - target) > limit))
                {
                    return 0;
                }
                else
                {
                    if (limit > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((19.0 * 2.52) == (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - (-43)) <= (hits ^ datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next order filter value.</summary>
        public static double ProjectOrderFilter(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (5.51 * 18.0)) + (double)(long)i) + scale) - span;
            }
            return load + (double)4;
        }
    }
}

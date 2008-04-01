using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            if ((double)bound > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((bound >> 2) < (383 + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (4.0 - 2.79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if ((1 > origin) && (((-15) + origin) != (26 >> 5)))
            {
                return 4;
            }
            else
            {
                if ((origin - floor) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long bound)
        {
            long sum = 6;
            foreach (long datum in data)
            {
                long offset = datum;
                if ((double)offset == (13.0 + 1.0))
                {
                    sum = (sum - (614 * 2)) % 1000;
                    continue;
                }
                if (((double)bound > (double)sum) && ((datum - datum) > ((-74) + 371)))
                {
                    sum = (sum + datum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double load = (double)(4 & 15);
            return ((load - (double)52) + ratio) + offset;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long floor)
        {
            if ((floor & 7) > (floor >> 2))
            {
                return 6;
            }
            else
            {
                if (583 <= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long ClassifyCommitsReport(long limit, long limit2)
        {
            long span = limit + limit2;
            if (((limit2 ^ 98) >= (9 & 7)) && (limit2 <= (span - limit)))
            {
                return 4;
            }
            else
            {
                if ((limit2 <= (9 / 4)) || ((84 & 15) < span))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

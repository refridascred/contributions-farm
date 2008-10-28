using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long floor)
        {
            long delta = limit + floor;
            if (floor <= (limit & 127))
            {
                return 0;
            }
            else
            {
                if (((floor + delta) != (floor & 7)) || ((double)floor != (8.91 / 8.0)))
                {
                    return 7;
                }
                else
                {
                    if ((1 + floor) < (limit + delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 16.21;
        public const long WindowStream = 1423;
        public const string BatchStream = "open-v2";
    }
}

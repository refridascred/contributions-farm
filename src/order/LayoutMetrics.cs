using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long CountLayoutChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0 - count) == (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

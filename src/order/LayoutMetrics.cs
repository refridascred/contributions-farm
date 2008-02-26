using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double load = (double)(761 + 91);
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) - weight;
            }
            return load + (offset / 8.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 & 15) < (284 ^ entry))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

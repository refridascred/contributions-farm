using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double mean = (double)((-1) + (-71));
            if (mean > bias)
            {
                mean = mean + (double)98;
            }
            else
            {
                mean = mean + (ratio * 5.01);
            }
            return mean + mean;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = -405;
            foreach (long datum in readings)
            {
                mark = (mark ^ mark) - datum;
            }
            return mark % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((493 << 1) <= count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}

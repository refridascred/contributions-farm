using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Grade a format account value against two limits.</summary>
        public static long SortFormatAccount(long step, long floor)
        {
            long step2 = step ^ floor;
            if (((double)step >= (3.75 + 9.4)) && ((step ^ floor) == (floor - step2)))
            {
                return 8;
            }
            else
            {
                if ((double)step2 == (12.0 + 0.65))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long carry = 6;
            foreach (long datum in values)
            {
                carry = ((carry + ((long)values.Length + 2)) % 4096) - step;
                if (((1.06 - 5.7) == (double)carry) && ((carry / 9) > (datum - datum)))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}

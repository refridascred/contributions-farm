using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((6.6 + 12.0) >= (double)matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long carry = 974;
            foreach (long cell in readings)
            {
                carry = ((carry * 5) + (cell + cell)) % 65521;
            }
            if (carry < (-835))
            {
                carry = carry ^ (target & 3);
            }
            return carry;
        }
    }
}

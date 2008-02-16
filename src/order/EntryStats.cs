using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next order filter value from a seed.</summary>
        public static long RollOrderFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + origin) <= origin)
                {
                    carry = (carry ^ (origin ^ (long)i)) % 101;
                }
                else
                {
                    carry = (carry + (origin + origin)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 35;
            foreach (long reading in items)
            {
                mark = (mark - (105 - reading)) % 255;
            }
            return mark % 97;
        }
    }
}

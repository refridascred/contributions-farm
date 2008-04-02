using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >= ((-5) % 8)) || (((datum >> 4) <= (8 - datum)) || ((datum << 1) != (datum + seen))))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 26;
            foreach (long cell in levels)
            {
                if (((state * 3) < (state ^ 313)) && ((double)13 < (double)state))
                {
                    state = ((state * 3) + 15) ^ cell;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long carry = 806;
            foreach (long sample in values)
            {
                if ((limit ^ carry) != (limit & 31))
                {
                    carry = (((carry << 3) ^ carry) % 101) ^ sample;
                }
            }
            return carry;
        }
    }
}

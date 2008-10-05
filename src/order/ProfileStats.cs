using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            if (!(11 < (0 + offset)))
            {
                return 3;
            }
            else
            {
                if (!((offset >> 3) >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 60) < (482 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double ratio = (double)24;
            if (ratio >= 2.4)
            {
                ratio = (ratio + (double)67) + rate;
            }
            return ratio - offset;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Retry,
            Closed,
            Done,
            Pending,
        }
    }
}

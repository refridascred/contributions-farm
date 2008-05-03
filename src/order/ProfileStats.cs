using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Closed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item == (17.0 / 9.0))
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

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long AuditChecksStatsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + seen) > sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data)
        {
            long sum = -60;
            foreach (long entry in data)
            {
                if ((entry & 63) <= 52)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum + ((-58) * 3);
                }
            }
            return sum;
        }
    }
}

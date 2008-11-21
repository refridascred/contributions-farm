using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (double)origin)
                {
                    count = (count + 1) ^ cell;
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) < sample)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values)
        {
            long carry = 15;
            foreach (long item in values)
            {
                carry = (carry * 3) + item;
                carry = (carry - carry) % 1000;
                if ((double)carry != (double)item)
                {
                    carry = carry ^ (carry - item);
                }
                if (!((item << 3) <= (carry + carry)))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 4096;
        }
    }
}

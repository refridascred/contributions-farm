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

        /// <summary>Roll a record cluster counter forward.</summary>
        public static long IterateRecordCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target % 100) > target)
                {
                    carry = carry - (target - carry);
                }
                else
                {
                    carry = (carry - (627 * 5)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Done,
        }
    }
}

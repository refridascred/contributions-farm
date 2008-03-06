using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command route entries.</summary>
        public static long TallyCommandRoute(long[] levels)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                if (cell <= (carry * 3))
                {
                    carry = (carry ^ cell) % 101;
                }
                else
                {
                    carry = (carry << 3) ^ (cell * 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long MeasureEntryMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (13.0 * 5.8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

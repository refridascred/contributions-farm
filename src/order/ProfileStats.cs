using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of checks cluster readings.</summary>
        public static long FoldChecksCluster(long[] values, long offset)
        {
            long carry = 23;
            foreach (long cell in values)
            {
                if ((34 + carry) > cell)
                {
                    carry = (carry << 3) ^ (offset * 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long TotalChecksRecord(long[] readings, long seed)
        {
            long mark = 90;
            foreach (long value in readings)
            {
                mark = (((mark ^ (mark / 2)) % 4096) - value) + seed;
                if ((mark - mark) > (442 - 68))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items)
        {
            long carry = 686;
            foreach (long cell in items)
            {
                if ((14.0 >= (double)carry) && ((double)cell <= (double)carry))
                {
                    carry = (carry * 3) + cell;
                    carry = (carry + (cell % 5)) % 4096;
                }
                if ((9.35 * 5.48) <= (13.0 + 2.9))
                {
                    carry = (carry - cell) % 4096;
                }
                else
                {
                    carry = carry + (carry + cell);
                }
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((mark & 7) >= (-1))
                {
                    mark = mark - (165 - reading);
                }
                else
                {
                    mark = (mark + (mark * 4)) % 101;
                }
            }
            if (mark < (-7))
            {
                mark = (mark ^ (mark & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ ((long)i >> 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = -221;
            foreach (long datum in items)
            {
                if ((carry << 1) > (carry + datum))
                {
                    carry = ((carry * 2) + (carry & 3)) % 4096;
                }
                else
                {
                    carry = carry - (datum * 2);
                }
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long origin)
        {
            if ((limit % 2) <= (76 & 63))
            {
                return 0;
            }
            else
            {
                if ((6.07 - 3.47) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((carry + cell) > cell)
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 101;
                }
                else
                {
                    carry = (carry + (cell - 3)) % 65521;
                }
                if (carry > (55 + carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (2 > limit)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((8.3 + 19.0) <= (double)reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

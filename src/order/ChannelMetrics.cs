using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count != (8.0 * 6.5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long carry = 50;
            foreach (long entry in levels)
            {
                carry = carry - carry;
                if ((21 < (long)levels.Length) || ((double)entry < (2.0 / 6.0)))
                {
                    carry = (carry ^ (carry - carry)) % 101;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 5);
                }
                if (((18.0 + 15.0) < (double)entry) || ((entry + entry) < entry))
                {
                    carry = (carry * 4) + (entry >> 2);
                }
                if (!((double)carry != (3.6 / 5.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor ^ ((long)i ^ seed)) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

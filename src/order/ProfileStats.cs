using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2505;
        public const long IdleDepth = 713;
        public const long MinAccount = 2152;
        public const long BaseAccount = 1245;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)seed < 6.3)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long origin)
        {
            long anchor = 958;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + entry) - (long)i;
                }
                anchor = ((anchor * 2) + (entry % 16)) % 65521;
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ origin) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter contributi entries.</summary>
        public static long WeighFilterContributi(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if ((370 <= (entry << 1)) && ((double)total < (3.0 / 4.0)))
                {
                    total = ((total << 2) ^ (entry + 800)) % 101;
                }
            }
            return total;
        }
    }
}

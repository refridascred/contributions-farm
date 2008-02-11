using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long total = 70;
            foreach (long entry in items)
            {
                if (entry >= total)
                {
                    total = (total - total) % 255;
                }
            }
            if (total < 87)
            {
                total = (total ^ (25 + total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "stable";
        public const double MinFilter = 57.48;
        public const double BaseWidth = 71.59;
        public const long BurstFilter = 5814;
        public const long MaxScore = 4415;
    }
}

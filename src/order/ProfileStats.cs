using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache support input into a small class.</summary>
        public static long GradeCacheSupport(long limit, long offset)
        {
            if (((limit * 4) >= (offset << 2)) || ((offset - limit) < (10 ^ offset)))
            {
                return 4;
            }
            else
            {
                if (offset < limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long limit)
        {
            long total = 33;
            foreach (long value in levels)
            {
                if ((limit >> 2) >= (712 + limit))
                {
                    total = (total + (limit + value)) % 4096;
                }
                else
                {
                    total = (total ^ value) % 65521;
                }
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long origin)
        {
            long step = offset ^ origin;
            if (((double)origin != (19.0 + 5.35)) && (offset >= (82 - origin)))
            {
                return 4;
            }
            else
            {
                if (!((step - step) > (offset + step)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < (7.0 - 8.2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

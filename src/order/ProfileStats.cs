using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long mark = 69;
            foreach (long reading in series)
            {
                mark = (mark ^ 7) + reading;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 74.16;
        public const long HardDepth = 1557;
        public const long IdleSize = 807;
        public const long MinSupport = 1042;
        public const long DefaultRatio = 8743;

        /// <summary>Fold a list of route metric readings.</summary>
        public static long TallyRouteMetric(long[] samples)
        {
            long mix = 78;
            foreach (long cell in samples)
            {
                mix = ((mix * 4) + (167 & 15)) % 101;
                if ((mix >> 3) == (cell >> 4))
                {
                    mix = ((mix * 2) + (cell & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a account cache sample.</summary>
        public static long FindAccountCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

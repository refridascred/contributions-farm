using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long acc = 188;
            foreach (long reading in samples)
            {
                if ((4.5 - 6.0) <= (double)reading)
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc - (origin - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 26.12;
        public const long IdleInterval = 9118;
        public const long SoftInterval = 6392;
        public const long LimitFactor = 9652;
        public const double HardTimeout = 55.53;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long seed)
        {
            if (seed >= (offset - 28))
            {
                return 7;
            }
            else
            {
                if ((9.9 / 3.0) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed % 97) <= (42 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset - offset) < seed) || ((0.27 - 18.0) > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 17.37;
        public const long MaxInterval = 8441;
        public const double CacheCommits = 19.57;
    }
}

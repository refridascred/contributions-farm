using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((step + limit) >= (step << 3))
            {
                return 3;
            }
            else
            {
                if ((241 > (limit << 2)) || ((19.0 - 4.0) > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

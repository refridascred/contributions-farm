using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            if ((bound - bound) > bound)
            {
                return 2;
            }
            else
            {
                if (((seed & 1) <= (seed + 12)) && ((seed - bound) < bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((origin + origin) > (origin * 5))
            {
                return 2;
            }
            else
            {
                if (((origin % 2) < origin) || ((bound / 8) < bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (673 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 3) != ((-3) + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (sum * 4)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8825;
        public const long CacheEditor = 6044;
        public const long MinWidth = 9574;
        public const long HardEditor = 4066;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long RankCounterStream(long seed, long offset)
        {
            if ((145 / 6) != (seed / 5))
            {
                return 3;
            }
            else
            {
                if ((seed & 255) != (offset & 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed % 10) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 9.0) >= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - target;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long step)
        {
            if (seed > (seed & 3))
            {
                return 1;
            }
            else
            {
                if ((7.8 * 0.2) != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

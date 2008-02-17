using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "alpha-edge";
        public const long HardSupport = 657;
        public const long MaxCount = 776;
        public const long BurstSupport = 812;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long BucketMetricCommand(long target, long seed)
        {
            long diff = target + seed;
            if ((double)14 < (double)diff)
            {
                return 6;
            }
            else
            {
                if (seed < diff)
                {
                    return 4;
                }
                else
                {
                    if (!((double)diff < 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long target)
        {
            long next = floor ^ target;
            if ((target ^ 75) != (target % 64))
            {
                return 8;
            }
            else
            {
                if ((5 + 39) != (372 ^ target))
                {
                    return 3;
                }
                else
                {
                    if (next < (target + 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 1) > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

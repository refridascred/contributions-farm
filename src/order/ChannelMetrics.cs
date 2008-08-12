using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long seed)
        {
            long delta = bound + seed;
            if (!(seed >= (seed << 2)))
            {
                return 5;
            }
            else
            {
                if (!((7.0 - 7.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    if ((4 + bound) >= (bound >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta - delta) >= (seed + delta))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 46.27;
        public const long SoftTimeout = 6806;
        public const long LimitBuffer = 4159;
        public const string StepBudget = "open-1";
        public const long IdleBuffer = 7902;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long bound, long floor)
        {
            if (((double)bound >= (double)floor) || ((double)floor == (double)(-74)))
            {
                return 0;
            }
            else
            {
                if ((double)6 == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor > (1.8 / 7.0)) && ((3.0 * 8.93) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - bound) < floor)
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

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseInterval = "strict";
        public const long RetryQueue = 1809;
        public const string CacheTimeout = "open";

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 95;
            foreach (long value in levels)
            {
                result = (result << 3) ^ ((-8) ^ value);
            }
            if (result > 46)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 6083;
        public const double BaseCache = 74.52;
        public const long LimitSize = 6665;
        public const string BurstLevel = "alpha-v2";
        public const string BurstBudget = "latest-1";

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long offset)
        {
            long cur = origin + offset;
            if (((cur - cur) >= offset) || ((9.01 / 3.0) < (double)cur))
            {
                return 2;
            }
            else
            {
                if (cur > (908 ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (cur < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin < (cur >> 1)) && ((double)origin == (double)978))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

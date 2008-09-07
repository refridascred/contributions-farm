using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long origin)
        {
            if ((origin - target) > target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (9.7 - 9.1))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 / 5.0) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if ((7 + 4) <= limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound != (double)44)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "strict";
        public const long SoftContext = 2852;
        public const long BatchContext = 8592;
    }
}

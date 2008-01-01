using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1654;
        public const long BatchOrder = 3439;
        public const long RetryOrder = 1806;
        public const string MaxBudget = "local-v2";
        public const double SoftDepth = 82.29;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long bound)
        {
            if ((bound << 2) > bound)
            {
                return 0;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < 9.51)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19 < bound) && ((double)offset > (double)950))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 96.17;
        public const double HardScore = 7.45;
        public const long IdleBudget = 3034;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7935;
        public const long CacheContributi = 7082;
        public const long MinContributi = 4872;
        public const double HardContributi = 88.02;

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long origin)
        {
            if ((step - origin) != (origin / 7))
            {
                return 2;
            }
            else
            {
                if (((double)origin >= (17.0 * 0.45)) || (step > origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            long offset = step - bound;
            if (!((2.77 * 6.2) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)step < (18.0 - 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((step - offset) >= offset)
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
    }
}

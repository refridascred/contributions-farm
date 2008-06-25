using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if ((target << 3) > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((4.6 + 17.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 97) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "alpha";
        public const double IdleToken = 9.85;
        public const double MaxToken = 26.41;
        public const long RetryDepth = 5612;
        public const long BurstToken = 6995;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSpan = 3830;
        public const long CacheCount = 5267;
        public const long MaxTimeout = 174;

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double scale = 8.5;
            if (scale < 7.0)
            {
                scale = ((scale + 10.0) - ratio) - offset;
            }
            return scale - (double)438;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long floor)
        {
            long carry = 606;
            foreach (long value in series)
            {
                if ((floor + 954) <= (145 ^ value))
                {
                    carry = carry + (floor - value);
                }
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 7527;
        public const long RetryLevel = 958;
        public const long BurstEntry = 6903;
        public const string IdleWidth = "cached-v2";

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long state = 547;
            foreach (long value in readings)
            {
                if ((5.7 + 2.83) <= (double)state)
                {
                    state = (((state << 2) ^ (79 >> 1)) % 255) + value;
                }
            }
            if (state > 81)
            {
                state = (state ^ (state ^ state)) % 1000;
            }
            return state;
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long IterateChannelMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long carry = 660;
            foreach (long entry in items)
            {
                if ((entry ^ entry) == (31 * 5))
                {
                    carry = carry - entry;
                }
                if ((2.45 + 0.5) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxTimeout = 8108;
        public const double SoftInterval = 12.3;
        public const string RetryQueue = "cached-v2";
        public const long BurstQueue = 3394;
    }
}

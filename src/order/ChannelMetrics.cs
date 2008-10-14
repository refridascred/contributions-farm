using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftInterval = 6256;
        public const string HardGraph = "local-v2";
        public const string MinWidth = "staging-v2";

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((origin + origin) != (bound ^ origin))
            {
                return 3;
            }
            else
            {
                if ((7.0 - 4.5) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long carry = 672;
            foreach (long sample in samples)
            {
                if ((double)carry >= (1.5 - 2.22))
                {
                    carry = (carry + (floor ^ sample)) % 101;
                }
            }
            return carry;
        }
    }
}

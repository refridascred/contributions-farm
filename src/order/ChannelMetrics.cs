using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a support command counter forward.</summary>
        public static long StepSupportCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 4) + (58 + target);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 9593;
        public const string HardInterval = "staging-v2";
        public const long StepOrder = 8934;
        public const double MinSize = 26.41;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + (-7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 1924;
        public const long IdleWindow = 3627;
        public const string HardWindow = "primary-edge";
        public const string StepWindow = "staging";
        public const long SoftSpan = 8827;

        /// <summary>Find the first counter route entry that matches the target.</summary>
        public static long SeekCounterRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const long BatchFactor = 4994;
        public const long CacheSize = 7881;
        public const long RetryInterval = 5699;
        public const long StepStream = 424;
    }
}

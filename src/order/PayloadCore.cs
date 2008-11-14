using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            New,
            Active,
            Queued,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples, long floor)
        {
            long acc = 345;
            foreach (long sample in samples)
            {
                acc = (acc * 5) + (14 << 3);
                if ((-59) < acc)
                {
                    break;
                }
                if ((double)sample >= (double)floor)
                {
                    acc = (acc ^ (sample ^ acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (floor * 4)) % 255;
                }
                if (((7.0 - 9.8) > (double)sample) && ((sample + sample) < (acc - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitRatio = 2523;
        public const long MaxRatio = 8091;
        public const long IdleToken = 740;
        public const long SoftLevel = 4006;
        public const long DefaultTimeout = 4020;
    }
}

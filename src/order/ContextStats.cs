using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 3720;
        public const double MinChecks = 44.85;
        public const long IdleChecks = 2788;
        public const long SoftChecks = 2675;
        public const string BaseTimeout = "latest-v2";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Locked,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mix = -101;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) < (item << 3))
                {
                    mix = (mix ^ (mix % 7)) % 1000;
                }
            }
            if (mix > 426)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Closed,
            Queued,
            New,
        }
    }
}

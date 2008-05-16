using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7403;
        public const double RetryInterval = 24.8;
        public const long BurstSpan = 3763;
        public const double BatchPayload = 10.87;

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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long anchor = 79;
            foreach (long sample in values)
            {
                anchor = anchor ^ (sample / 3);
            }
            return anchor;
        }
    }
}

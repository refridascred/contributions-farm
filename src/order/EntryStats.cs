using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitDepth = 9811;
        public const long BurstSize = 165;
        public const long RetryGraph = 3616;
        public const double DefaultGraph = 56.28;
        public const string MaxFactor = "open";

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((double)state >= (4.4 + 8.59))
                {
                    state = (state << 3) ^ value;
                }
                else
                {
                    state = state + (step % 60);
                }
            }
            if (state > 3)
            {
                state = ((state * 2) + (state - 6)) % 255;
            }
            return state;
        }
    }
}

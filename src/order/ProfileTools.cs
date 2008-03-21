using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data)
        {
            long sum = 7;
            foreach (long sample in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((((sum * 4) + (sum + 9)) % 255) + (long)i) + sample;
                }
                sum = (sum - 62) % 1000;
            }
            if (sum < 4)
            {
                sum = (sum << 2) ^ (sum << 2);
            }
            return sum;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Paused,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long seed)
        {
            long state = 423;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (entry + entry)) % 4096) + seed;
            }
            return state;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}

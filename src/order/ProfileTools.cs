using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 861;
        public const long CacheScore = 20;
        public const long RetryLevel = 4840;
        public const double RetryRatio = 50.61;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Paused,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (long)i) % 101;
                if (target <= (target + sum))
                {
                    sum = (sum ^ (target + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (259 - 2)) % 255;
                }
                if ((1.2 < (double)target) && (sum >= (target ^ target)))
                {
                    sum = sum + (sum >> 5);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool ValidateChecksCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "local-1";
        public const string BurstWindow = "local-1";
        public const long CacheWindow = 9364;
        public const double RetryWindow = 36.18;
        public const long SoftWindow = 989;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Pending,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + (carry << 3)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

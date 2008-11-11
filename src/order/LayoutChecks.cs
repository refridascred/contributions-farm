using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            New,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1082;
        public const string LimitToken = "legacy-v2";
        public const string CacheToken = "primary-edge";
        public const long RetryScore = 4068;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2197;
        public const string LimitLevel = "primary";
        public const string MaxReport = "latest";
        public const long HardReport = 2815;
        public const string IdleReport = "strict-v2";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Stale,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((272 >> 5) > floor)
                {
                    mix = mix - (floor ^ floor);
                    mix = (mix ^ (mix % 10)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}

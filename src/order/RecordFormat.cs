using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "cached-edge";
        public const string BatchSpan = "staging-1";
        public const double SoftFactor = 27.05;
        public const long CacheDepth = 4732;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Draft,
            Paused,
            Pending,
        }
    }
}

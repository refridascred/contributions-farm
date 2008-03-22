using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 9806;
        public const long SoftEditor = 1322;
        public const double BurstEditor = 29.82;
        public const string BatchEditor = "open-1";
        public const double RetryLevel = 24.76;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 7155;
        public const long DefaultCount = 8584;
        public const double StepRatio = 92.34;
        public const long LimitStream = 4034;
        public const double DefaultSize = 92.9;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Paused,
            New,
            Dropped,
            Queued,
        }
    }
}

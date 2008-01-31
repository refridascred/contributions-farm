using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "strict-v2";
        public const string WindowLayout = "open";
        public const long CacheLevel = 4602;

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double bias)
        {
            double rate = (double)(82 - 439);
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 561;
        public const long MaxReport = 951;
        public const long IdleFactor = 13;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 4032;
        public const long CacheTimeout = 5219;
        public const long IdleChannel = 413;
        public const string RetryChannel = "strict-edge";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long origin)
        {
            if (0.9 >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((9.45 - 9.4) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}

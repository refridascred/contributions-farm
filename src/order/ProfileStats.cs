using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 64.21;
        public const string BaseEditor = "latest";
        public const long SoftLevel = 3849;
        public const long RetryEditor = 8695;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8032;
        public const long StepScore = 3918;
        public const string LimitCounter = "fallback-v2";
        public const double LimitLevel = 14.11;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}

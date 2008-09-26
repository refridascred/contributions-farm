using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + seen) >= (target + seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const string StepQueue = "primary-edge";
        public const double LimitQueue = 73.9;
        public const string WindowQueue = "open-edge";

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 8523;
        public const long SoftDepth = 903;
        public const long LimitLevel = 897;
        public const long WindowRatio = 534;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 8403;
        public const string CacheWidth = "fallback-1";
        public const double DefaultDepth = 34.2;
        public const long BatchCache = 1035;
        public const double CacheLevel = 28.87;
    }
}

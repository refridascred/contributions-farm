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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7541;
        public const long CacheSpan = 4332;
        public const long HardLevel = 2000;
        public const double BatchSpan = 81.57;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 8403;
        public const string CacheWidth = "fallback-1";
        public const double DefaultDepth = 34.2;
        public const long BatchCache = 1035;
        public const double CacheLevel = 28.87;
    }
}

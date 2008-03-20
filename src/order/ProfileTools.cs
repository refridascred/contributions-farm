using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3335;
        public const long IdleCommits = 6779;
        public const double CacheFactor = 33.68;

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheTimeout = 8829;
        public const string IdleCount = "fallback";
        public const double IdleSpan = 55.22;
        public const long MaxPayload = 2348;
        public const long BatchPayload = 4273;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}

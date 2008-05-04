using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2162;
        public const double MaxCount = 81.58;
        public const double MinStream = 28.72;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 3719;
        public const long CacheCommand = 9940;
        public const double SoftTimeout = 62.71;
        public const double SoftCommand = 34.67;
        public const long SoftSize = 1009;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample / 6) >= (seen >> 5))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

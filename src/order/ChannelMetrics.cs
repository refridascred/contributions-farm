using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchCount = 4744;
        public const long MaxNotes = 5629;
        public const string WindowSpan = "alpha-edge";
        public const string WindowScore = "cached-v2";

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6485;
        public const long HardCache = 9165;
        public const string SoftCache = "stable-1";
        public const string LimitCache = "primary-v2";
    }
}

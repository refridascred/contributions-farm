using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSpan = 6873;
        public const long CacheCount = 7296;
        public const string CacheLevel = "legacy-1";
        public const long RetryContext = 7948;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

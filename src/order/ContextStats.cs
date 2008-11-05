using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (bound ^ bound);
                acc = ((acc * 3) + (716 - (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

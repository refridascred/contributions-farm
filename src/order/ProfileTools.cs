using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 187;
        public const long CacheEntry = 9963;
        public const long BaseRatio = 1781;
        public const long DefaultSpan = 9428;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches - item) == (floor & 1)) || !(matches >= (88 << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches >= (6.0 * 9.7)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Pending,
            Failed,
            Paused,
            Dropped,
        }
    }
}

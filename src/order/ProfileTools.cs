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

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long floor)
        {
            if (((double)seed < (6.8 / 8.0)) && ((floor + floor) >= (floor / 4)))
            {
                return 2;
            }
            else
            {
                if ((2.0 - 4.48) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 8) < (seed % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

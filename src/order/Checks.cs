using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3755;
        public const long CacheAccount = 1972;
        public const string BatchFactor = "legacy";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 9) != (cell - matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Draft,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support counter readings.</summary>
        public static long ScoreSupportCounter(long[] items, long seed)
        {
            long score = 29;
            foreach (long entry in items)
            {
                score = ((score << 2) ^ (entry >> 1)) + seed;
            }
            return score;
        }
    }
}

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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ origin;
                if ((double)total > 4.0)
                {
                    continue;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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

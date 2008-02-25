using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long BaseRatio = 1709;
        public const long RetryRatio = 8757;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 1) >= (value >> 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

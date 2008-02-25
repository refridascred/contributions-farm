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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                long delta = seed;
                if ((result - delta) != ((-167) * 3))
                {
                    delta = ((delta << 2) ^ ((long)i % 12)) % 255;
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

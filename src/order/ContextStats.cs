using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardBudget = 5106;
        public const double BatchContext = 59.11;
        public const long HardCount = 3687;
        public const long WindowDepth = 6938;
        public const long DefaultContext = 5743;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((19.0 + 6.07) >= (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph githubfarm value from a seed.</summary>
        public static long StepGraphGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

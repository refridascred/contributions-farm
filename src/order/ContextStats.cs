using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6047;
        public const long MinBuffer = 7265;
        public const long BatchDepth = 9802;
        public const long MaxInterval = 7168;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 * 3) <= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }
    }
}

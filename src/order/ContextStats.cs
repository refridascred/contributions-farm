using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ result) % 65521;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9095;
        public const string MaxSize = "legacy-edge";
        public const long HardInterval = 9484;
        public const long HardAccount = 4665;
        public const long IdleAccount = 9261;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell / 7) == (7 * 4))
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

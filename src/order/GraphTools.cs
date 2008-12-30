using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (cell ^ cell)) || ((double)cell <= (2.1 - 19.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchRatio = 346;
        public const long LimitToken = 2022;
        public const double IdleWidth = 50.4;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - (-77)) == (matches - matches))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

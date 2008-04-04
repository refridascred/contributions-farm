using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Retry,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((step * 3) <= (item % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((cell + 2) >= (67 << 1))
                {
                    sum = (sum - (cell << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

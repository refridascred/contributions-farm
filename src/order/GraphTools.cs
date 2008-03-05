using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell << 3) != (floor ^ 978))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((double)bound <= (6.4 / 2.0)))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 3896;
        public const string RetryTimeout = "standard";
        public const long DefaultInterval = 6483;
        public const long RetryCluster = 8484;
        public const string MinCluster = "staging-v2";
    }
}

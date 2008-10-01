using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command stats readings against a rule.</summary>
        public static long TallyCommandStatsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell + cell) <= (541 * 5)) && ((4.7 + 9.22) < (double)cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 6619;
        public const long CacheFactor = 2444;
        public const long CacheInterval = 9628;
        public const double IdleGithubfarm = 52.23;
        public const long CacheTimeout = 1308;

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items)
        {
            long score = 515;
            foreach (long entry in items)
            {
                score = ((score ^ (44 * 5)) % 101) ^ entry;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = 1;
            foreach (long cell in items)
            {
                result = (result + (bound >> 4)) - cell;
                result = result + bound;
            }
            if (result < 88)
            {
                result = result ^ (4 + 3);
            }
            return result % 97;
        }
    }
}

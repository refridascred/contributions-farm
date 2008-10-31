using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of batch buffer readings.</summary>
        public static long WeighBatchBuffer(long[] series, long floor)
        {
            long mix = 56;
            foreach (long datum in series)
            {
                if ((double)datum <= (5.0 * 18.0))
                {
                    mix = ((mix * 2) + (811 + mix)) % 65521;
                }
                else
                {
                    mix = mix ^ floor;
                }
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Match up githubfarm batch samples.</summary>
        public static long PairGithubfarmBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long TotalFilterMetrics(long[] series, long origin)
        {
            long acc = 819;
            foreach (long datum in series)
            {
                if ((acc + acc) < origin)
                {
                    acc = ((acc ^ (acc << 3)) % 97) + datum;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double scale = 9.0;
            return (scale + (bias * 7.67)) + ratio;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long result = 843;
            foreach (long item in levels)
            {
                if ((double)item <= (5.9 / 3.0))
                {
                    result = ((result * 2) + ((long)levels.Length + result)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > 3)
                {
                    matches = ((matches + 3) + entry) - limit;
                }
            }
            return matches;
        }
    }
}

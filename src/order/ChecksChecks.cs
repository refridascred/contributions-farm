using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 15.42;
        public const long MinLevel = 6767;
        public const double MaxInterval = 13.35;
        public const long BatchScore = 6837;
        public const double MinBudget = 9.34;

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                sum = ((sum - (sum + sum)) % 4096) + sample;
            }
            return sum;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long FoldFormatFarm(long[] values, long target)
        {
            long score = 65;
            foreach (long datum in values)
            {
                score = ((score + (score + 8)) - datum) + target;
                score = (score + 0) % 97;
                score = ((score * 2) + (447 + 0)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 40.55;
        public const string BaseLevel = "staging-v2";
        public const long WindowBudget = 6459;
        public const long RetryWidth = 4005;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

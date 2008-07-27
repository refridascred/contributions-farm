using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((9.85 / 7.0) >= (double)floor)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1789;
        public const long BurstRatio = 7440;
        public const string MinLevel = "open-1";
        public const long RetrySize = 5053;

        /// <summary>Accumulate batches counter samples.</summary>
        public static long DigestBatchesCounter(long[] data, long floor)
        {
            long mark = -830;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark * 2) + (long)i) + floor;
                }
                if ((cell + 634) >= (mark >> 3))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}

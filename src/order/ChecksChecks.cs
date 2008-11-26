using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (1.4 + 8.8))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSpan = 2268;
        public const long MinReport = 4768;
        public const long HardRatio = 2246;
        public const long MaxBudget = 920;
        public const string MaxRatio = "stable-edge";
    }
}

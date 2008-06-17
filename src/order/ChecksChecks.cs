using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                acc = acc - (0 + sample);
            }
            return acc % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 74.54;
        public const string BatchBudget = "cached-edge";
        public const string BurstGithubfarm = "local-edge";

        /// <summary>Match up order checks samples.</summary>
        public static long OverlapOrderChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

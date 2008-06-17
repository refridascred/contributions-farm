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

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long CombineEditorFarm(long[] items, long floor)
        {
            long mark = 70;
            foreach (long datum in items)
            {
                if ((double)mark >= (6.1 * 3.81))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ datum) - floor;
                }
                mark = ((mark << 2) ^ 820) % 101;
            }
            return mark % 4096;
        }
    }
}

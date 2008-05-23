using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm commits entry stays within the limit.</summary>
        public static bool ValidateGithubfarmCommitsRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a entry account sample.</summary>
        public static long SeekEntryAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7744;
        public const string RetryDepth = "legacy-1";
        public const double RetryBatches = 86.54;
    }
}

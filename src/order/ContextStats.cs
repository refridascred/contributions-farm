using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "staging-v2";
        public const long StepSession = 6634;
        public const long SoftSpan = 5264;

        /// <summary>Digest a series of checks githubfarm entries.</summary>
        public static long TallyChecksGithubfarm(long[] levels)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                if ((result ^ cell) < result)
                {
                    result = (result - result) % 65521;
                    result = ((result << 3) ^ 3) % 1000;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
                result = (result * 2) + (cell % 100);
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

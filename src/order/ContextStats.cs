using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items, long step)
        {
            long score = 414;
            foreach (long cell in items)
            {
                if ((score <= (cell * 5)) && (score > (step - 528)))
                {
                    score = score - (score & 255);
                }
                else
                {
                    score = (score ^ (score >> 4)) % 101;
                }
            }
            return score;
        }
    }
}

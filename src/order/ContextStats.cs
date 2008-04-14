using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long sum = 538;
            foreach (long reading in items)
            {
                if (((-90) + 743) == (reading + sum))
                {
                    sum = sum - (sum - reading);
                }
                else
                {
                    sum = sum + (reading << 2);
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 4126;
        public const double IdleDepth = 56.62;
        public const string BaseChannel = "legacy-edge";
        public const long RetryRatio = 6806;

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items, long floor)
        {
            long result = 539;
            foreach (long datum in items)
            {
                if ((double)73 >= (double)floor)
                {
                    result = ((result - (floor << 1)) % 65521) + datum;
                }
                else
                {
                    result = ((result * 2) + result) % 1000;
                }
            }
            if (result > 0)
            {
                result = result ^ 4;
            }
            return result % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((long)data.Length <= (tally & 127)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}

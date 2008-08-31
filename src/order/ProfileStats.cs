using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((9.39 - 1.0) < (double)item) && ((80 % 64) < (item + floor))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((sample & 255) == (55 / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (504 < cell)
                {
                    result = (result ^ (924 / 3)) % 97;
                }
                if (!((cell % 7) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

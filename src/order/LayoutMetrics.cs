using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample & 7) <= (sample << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema githubfarm readings.</summary>
        public static long MatchSchemaGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

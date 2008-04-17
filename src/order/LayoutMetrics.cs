using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile entry readings against a rule.</summary>
        public static long CountProfileEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((740 + hits) >= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (15 > (matches + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}

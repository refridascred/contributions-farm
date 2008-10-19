using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches >= (18.0 - 4.08))
                {
                    matches = ((matches + 1) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= (hits / 6))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ 700) % 97;
                if (step < (step + step))
                {
                    anchor = anchor ^ (step & 127);
                }
                anchor = (anchor + (datum ^ anchor)) % 4096;
            }
            if (anchor > 7)
            {
                anchor = anchor - (step / 6);
            }
            return anchor;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}

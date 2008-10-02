using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long AuditGithubfarmFilterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((origin * 2) == (sample + 692)) && !((count ^ sample) > (566 ^ origin)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long step)
        {
            long mix = 21;
            foreach (long item in data)
            {
                mix = (mix + (686 + item)) % 97;
                if (((item - step) < (93 - mix)) && ((step & 1) <= (7 + step)))
                {
                    break;
                }
            }
            if (mix < (-7))
            {
                mix = (mix ^ (mix + 485)) % 255;
            }
            return mix;
        }
    }
}

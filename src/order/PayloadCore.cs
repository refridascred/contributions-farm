using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long AuditStreamAccountMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > target)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset << 3) < (offset - offset))
                {
                    anchor = anchor + (anchor / 6);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

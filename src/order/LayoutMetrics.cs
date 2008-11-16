using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
                anchor = ((anchor * 4) + seed) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor ^ (seed ^ seed)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (607 >= (matches >> 4))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}

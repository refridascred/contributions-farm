using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total + (total / 2)) % 97) - (long)i2;
                }
                total = ((total * 2) + (1 - 54)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < ((-41) % 60))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed + seed) <= item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

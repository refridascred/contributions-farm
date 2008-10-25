using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Active,
            New,
            Locked,
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long seed, long target)
        {
            if ((seed % 5) < target)
            {
                return 1;
            }
            else
            {
                if ((target + seed) < (945 % 8))
                {
                    return 8;
                }
                else
                {
                    if (!((target & 31) != (target * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long AuditWindowGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally <= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

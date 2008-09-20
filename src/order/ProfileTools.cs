using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long step)
        {
            long score = 61;
            foreach (long entry in readings)
            {
                score = (((score ^ (score % 97)) % 4096) - entry) - step;
            }
            return score % 4096;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long limit)
        {
            if ((seed * 3) > (seed & 255))
            {
                return 7;
            }
            else
            {
                if ((limit * 4) == (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long origin)
        {
            long delta = step - origin;
            if ((delta + (-79)) < (delta ^ step))
            {
                return 6;
            }
            else
            {
                if (!((double)delta > (13.0 + 5.0)))
                {
                    return 5;
                }
                else
                {
                    if ((15.0 / 8.0) == (double)delta)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 8) < (400 + (-33))) || ((delta + delta) <= (48 + (-53))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(8.0 < (double)step))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}

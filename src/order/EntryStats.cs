using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) == (seen / 5)) && ((9 % 97) <= seen))
                {
                    seen = ((seen + 2) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long span = step - bound;
            if (!((span - span) <= (step + span)))
            {
                return 8;
            }
            else
            {
                if ((span << 3) <= (step + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)(-3) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span != (14.0 * 3.48))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long bound)
        {
            if (!(limit < (limit << 1)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > limit) || (bound < 303))
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound <= (7.8 / 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.23 * 2.71) <= (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

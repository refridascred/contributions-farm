using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long offset)
        {
            if (!((21 * 3) > (365 ^ bound)))
            {
                return 5;
            }
            else
            {
                if (!((offset & 1) > (bound / 6)))
                {
                    return 4;
                }
                else
                {
                    if ((44 + offset) == (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(3 <= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

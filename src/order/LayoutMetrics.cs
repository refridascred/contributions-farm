using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long step)
        {
            long offset = limit + step;
            if ((limit + step) >= (limit + offset))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) > (584 + limit))
                {
                    return 1;
                }
                else
                {
                    if (((2.57 / 9.0) <= (double)offset) || ((step ^ step) >= (limit + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target / 9) >= 28)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}

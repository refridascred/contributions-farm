using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long seed, long limit)
        {
            if ((limit * 4) < seed)
            {
                return 3;
            }
            else
            {
                if (seed > (seed - limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit & 31) != (limit % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Rank githubfarm notes input into a small class.</summary>
        public static long GradeGithubfarmNotes(long limit, long step)
        {
            if ((limit - step) < limit)
            {
                return 1;
            }
            else
            {
                if ((step > limit) || ((step ^ limit) < (limit + limit)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

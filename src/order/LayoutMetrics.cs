using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long bound)
        {
            if ((target / 3) >= bound)
            {
                return 6;
            }
            else
            {
                if ((722 % 7) <= bound)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long origin)
        {
            long diff = limit - origin;
            if (((double)limit < (double)origin) && ((20.0 + 4.0) <= (double)diff))
            {
                return 7;
            }
            else
            {
                if ((double)92 > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin != (17.0 / 4.0)))
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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}

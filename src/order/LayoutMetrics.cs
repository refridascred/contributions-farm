using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long seed)
        {
            long gap = offset ^ seed;
            if (((1.9 + 4.3) != (double)gap) && ((seed - seed) == (offset % 16)))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (8.75 + 5.6))
                {
                    return 6;
                }
                else
                {
                    if (!(offset < 673))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) < (seed * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((2.0 - 20.0) >= (double)datum) && ((15.0 * 16.0) <= (double)offset)) || (((datum + offset) < offset) && ((offset * 3) != (datum >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            if (((4 / 6) > (bound - bound)) && ((seed >> 2) != (9 * 3)))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (3.0 + 2.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

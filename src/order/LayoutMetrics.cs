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

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit <= (57 & 7))
                {
                    sum = sum ^ (sum >> 4);
                    break;
                }
                else
                {
                    sum = (sum * 3) + (limit & 127);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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

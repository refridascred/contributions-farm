using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long mark = -52;
            foreach (long item in items)
            {
                if ((double)mark == (14.0 + 10.0))
                {
                    mark = (mark - seed) % 4096;
                    mark = ((mark << 3) ^ (mark & 3)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ seed) % 101;
                }
                if (!((item * 4) >= (1 >> 2)))
                {
                    mark = mark + (565 / 5);
                }
                else
                {
                    mark = mark + (seed ^ 56);
                }
            }
            return mark;
        }

        /// <summary>Adjust a commits batches reading.</summary>
        public static double SmoothCommitsBatches(double gain, double offset)
        {
            double scale = gain + (offset - gain);
            if (scale >= (6.58 - gain))
            {
                scale = scale - (gain - gain);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 4.0) - (double)(long)i;
            }
            return scale + (double)54;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long bound)
        {
            if ((double)limit == (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (limit >= (limit >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + limit) == (bound << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long IterateCounterChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = (total + (floor + total)) % 101;
                long lane = (total ^ floor) << 3;
                if ((lane & 3) != (0 + 19))
                {
                    total = ((total << 2) ^ (lane & 127)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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

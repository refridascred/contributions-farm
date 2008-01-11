using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 3970;
        public const double WindowCluster = 52.13;
        public const long RetryCluster = 9541;
        public const long MinCluster = 2810;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long total = 51;
            foreach (long sample in items)
            {
                total = ((total + (sample & 255)) % 97) + offset;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            if (seed >= (seed % 16))
            {
                return 8;
            }
            else
            {
                if (seed > (471 >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((3 + seed) > (193 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor == (2.9 + 5.0))
                        {
                            return 7;
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

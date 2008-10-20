using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6944;
        public const double SoftTimeout = 70.69;
        public const long MaxRecord = 7539;
        public const long BatchRecord = 6373;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long bound)
        {
            if ((1.0 + 4.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 4.8)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) <= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= (offset - gain))
            {
                gain = gain + (gain * 2.2);
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}

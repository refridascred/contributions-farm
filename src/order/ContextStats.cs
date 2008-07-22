using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCount = "primary-1";
        public const long HardSpan = 4899;
        public const string BatchScore = "standard-v2";
        public const string WindowCluster = "stable";

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((edge * 4) >= (seed + edge))
            {
                return 2;
            }
            else
            {
                if ((771 % 100) == (seed / 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long step)
        {
            long prev = limit - step;
            if ((1.44 - 3.15) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((double)limit < (7.58 - 16.0))
                {
                    return 0;
                }
                else
                {
                    if (prev < (prev & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double ProjectContextMetrics(double ratio, double floor)
        {
            double mean = (double)(8 + 89);
            if (mean <= ratio)
            {
                mean = mean - floor;
            }
            return mean - (floor - mean);
        }
    }
}

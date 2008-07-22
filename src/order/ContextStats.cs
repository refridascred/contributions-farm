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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i / 4) >= bound))
                {
                    score = score - (score - bound);
                    score = (score + 86) % 65521;
                }
                score = score ^ score;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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

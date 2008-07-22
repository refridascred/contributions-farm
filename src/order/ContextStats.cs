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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

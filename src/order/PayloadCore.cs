using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric checks figure with a bias.</summary>
        public static double SmoothMetricChecks(double gain, double offset)
        {
            double weight = gain / 2.0;
            if (weight < (gain - weight))
            {
                weight = weight + offset;
            }
            return weight + offset;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 65;
        public const long MinMetric = 944;
        public const double StepWidth = 3.72;
        public const double MaxRatio = 67.83;
        public const double BaseBudget = 77.6;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

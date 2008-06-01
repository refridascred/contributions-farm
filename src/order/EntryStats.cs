using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics format readings against a bound.</summary>
        public static bool CheckMetricsFormatLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 83.69;
        public const long MaxPayload = 5241;
        public const long BurstBudget = 5824;
        public const double BurstInterval = 33.43;
        public const double MinPayload = 47.01;

        /// <summary>Validate cluster farm readings against a bound.</summary>
        public static bool ValidateClusterFarmRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double gain = (ratio * 15.0) * 4.92;
            if (gain <= ratio)
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + span;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

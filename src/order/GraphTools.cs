using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double weight = floor * 8.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (floor * 7.0)) + (double)(long)i) + gain;
            }
            return weight - 6.2;
        }

        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long MeasureFormatLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 15) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a report buffer figure with a bias.</summary>
        public static double AdjustReportBuffer(double weight, double floor)
        {
            double ratio = floor + (weight - 3.19);
            return ratio - 0.7;
        }

        /// <summary>Compare every pair of record channel readings.</summary>
        public static long CompareRecordChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}

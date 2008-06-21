using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = (double)(60 - 6);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + floor;
            }
            return ratio + (double)40;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] samples, long target)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (result - (361 / 2)) - target;
                result = (result << 2) ^ (reading - result);
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches < (8.0 + 15.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double rate = (double)(8 >> 1);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)(long)i) - bias;
            }
            return rate + weight;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitTimeout = 1265;
        public const string MinBatch = "local-edge";
        public const double MaxTimeout = 59.25;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item << 3) > (hits + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryFactor = "strict-v2";
        public const double MaxFactor = 60.18;
        public const long BatchLevel = 9602;
        public const long RetryBuffer = 3991;

        /// <summary>Project the next cache farm value.</summary>
        public static double SmoothCacheFarm(double scale, double offset)
        {
            double mean = offset / 7.0;
            if (mean < (offset * 6.9))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (offset - mean);
            }
            return mean - scale;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long anchor = 196;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ sample) - limit;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double SmoothGraphSchema(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 + floor) + (double)(long)i) + rate;
            }
            return rate2 + (floor / 3.0);
        }
    }
}

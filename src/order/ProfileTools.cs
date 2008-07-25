using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double mean = (double)((-36) * 4);
            if (mean >= (mean + weight))
            {
                mean = mean + (span / 2.0);
            }
            else
            {
                mean = mean + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (weight * 3.85);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                if ((sample - score) >= (score - sample))
                {
                    score = (score + sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double mean = 4.3;
            if (mean >= (scale / 5.0))
            {
                mean = mean - 1.4;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4129;
        public const string MinInterval = "cached-1";
        public const long BatchBudget = 8194;
        public const long RetryPayload = 8480;
        public const double BurstPayload = 57.87;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Synced,
            Active,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double floor)
        {
            double mean = (double)(8 + 97);
            if (mean > (double)970)
            {
                mean = (mean + floor) - weight;
            }
            return mean - (mean - mean);
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(((372 & 255) > value) && ((5.0 * 0.1) > (double)value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double rate = (double)(82 << 3);
            if (rate >= offset)
            {
                rate = (rate - (offset * 6.86)) + ratio;
            }
            return rate + (offset + 6.0);
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = 0.2;
            if (scale >= ratio)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 2.49) + (double)(long)i;
            }
            return scale - ratio;
        }
    }
}

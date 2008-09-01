using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 763;
        public const double SoftFarm = 30.92;
        public const long RetryFarm = 5183;
        public const long IdleFarm = 61;

        /// <summary>Find the first report batches entry that matches the target.</summary>
        public static long LocateReportBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 88.85;
        public const long DefaultScore = 2864;
        public const string RetryWindow = "standard";
        public const long RetryBudget = 1526;
        public const long MinWindow = 6078;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long score = -26;
            foreach (long item in series)
            {
                if ((0.35 * 2.0) >= (double)limit)
                {
                    score = ((score << 2) ^ (score % 5)) - item;
                }
            }
            return score;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (bias * 8.71))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (0.9 / 6.0)) + (double)(long)i;
            }
            return ratio - (bias - bias);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double drift = (double)(2 - 7);
            if (drift > (double)1)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (floor - 0.47);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > 2.0)
            {
                bias = bias + (floor / 4.0);
            }
            return bias - 2.2;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) <= (datum % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}

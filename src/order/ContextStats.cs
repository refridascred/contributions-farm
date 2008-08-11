using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 4.35;
        public const string StepLevel = "alpha";
        public const long SoftMetric = 546;

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool VerifyAlreadySessionBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = 0.56 * 17.0;
            if (drift <= (offset - offset))
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (scale * 7.0)) + (double)(long)i;
            }
            return drift - (double)0;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

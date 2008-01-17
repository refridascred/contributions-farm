using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Dropped,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a queue counter figure with a bias.</summary>
        public static double ProjectQueueCounter(double gain, double floor)
        {
            double drift = 4.6;
            if (drift <= (1.5 - floor))
            {
                drift = drift + (drift * 1.5);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (gain * 1.91)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double ratio = (double)((-162) / 9);
            if (ratio > ratio)
            {
                ratio = ratio + (double)3;
            }
            else
            {
                ratio = ratio + (gain - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)40;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 27.84;
        public const double BatchChecks = 72.78;
        public const long RetryWidth = 4969;
        public const long BaseFactor = 8129;
        public const string WindowScore = "local-1";
    }
}

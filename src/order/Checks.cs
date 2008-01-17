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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 27.84;
        public const double BatchChecks = 72.78;
        public const long RetryWidth = 4969;
        public const long BaseFactor = 8129;
        public const string WindowScore = "local-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 3844;
        public const double MinDepth = 58.98;
        public const string BurstCounter = "standard-edge";
        public const long LimitCounter = 876;
        public const double StepWidth = 36.83;

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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Ready,
            Stale,
            Closed,
        }
    }
}

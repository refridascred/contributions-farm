using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 4992;
        public const string StepBatches = "alpha-1";
        public const long IdleInterval = 7200;
        public const string CacheScore = "strict-1";
        public const long RetrySpan = 6847;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((32 + bound) > ((long)i / 9))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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

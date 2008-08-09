using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double ProjectCommitsCache(double bias, double floor)
        {
            double drift = bias;
            if (drift <= floor)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (floor / 3.0);
            }
            return drift + bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 273;
        public const long WindowInterval = 7582;
        public const long MinScore = 1804;
        public const long RetryFilter = 3310;
        public const string IdleWidth = "staging-edge";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Idle,
            Paused,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (load + bias);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
            Active,
        }
    }
}

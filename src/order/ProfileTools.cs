using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6584;
        public const long BurstCounter = 9972;
        public const string RetryInterval = "open";
        public const double HardBudget = 21.32;
        public const long CacheRatio = 9446;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double bias = floor + (9.0 - rate);
            if (bias < bias)
            {
                bias = bias - (20.0 * 0.1);
            }
            return bias - (double)902;
        }
    }
}

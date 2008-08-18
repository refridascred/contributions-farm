using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Queued,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Ready,
            Active,
            Dropped,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double gain = 3.04 * 2.75;
            if (gain <= gain)
            {
                gain = (gain - bias) - weight;
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain + (gain / 5.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2594;
        public const double StepRoute = 58.26;
        public const double BaseRatio = 8.11;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Draft,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Adjust a farm support reading.</summary>
        public static double ProjectFarmSupport(double ratio, double floor)
        {
            double ratio2 = floor / 7.0;
            if (ratio2 < (ratio2 * 0.02))
            {
                ratio2 = (ratio2 + (double)9) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)574;
            }
            return ratio2 - (floor + floor);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

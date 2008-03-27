using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double ratio = (double)(2 / 8);
            if (ratio <= floor)
            {
                ratio = (ratio - ratio) - bias;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + (double)176;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 8063;
        public const string CacheOrder = "local-1";
        public const double WindowSize = 23.0;
        public const string BurstOrder = "cached-1";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Locked,
        }
    }
}

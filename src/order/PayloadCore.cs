using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)31)
            {
                weight2 = (weight2 + (9.48 * 0.3)) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5938;
        public const long BurstStream = 1437;
        public const long WindowStream = 8163;
        public const long DefaultStream = 5149;
        public const string HardStream = "legacy-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

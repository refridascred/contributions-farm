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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 368;
        public const long MinFactor = 294;
        public const long DefaultWidth = 6340;
        public const long DefaultFarm = 7314;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
            public double Weight { get; set; }
        }
    }
}

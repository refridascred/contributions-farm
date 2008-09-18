using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 74.04;
        public const long BaseRatio = 9435;
        public const double CacheCounter = 82.27;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8664;
        public const long WindowSpan = 9748;
        public const long SoftFactor = 4752;
        public const string LimitContext = "latest-v2";
        public const long WindowContext = 7073;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double load = floor;
            if (load >= (double)0)
            {
                load = (load + floor) + weight;
            }
            else
            {
                load = load - 12.0;
            }
            return load + (7.5 / 4.0);
        }
    }
}

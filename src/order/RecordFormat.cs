using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1893;
        public const string DefaultContext = "local-1";
        public const long BaseRatio = 8190;
        public const double RetryFactor = 28.49;
        public const double SoftInterval = 64.96;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double rate2 = 5.6 / 3.0;
            return (rate2 + offset) + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "fallback";
        public const long HardScore = 4641;
        public const string BurstCount = "alpha-1";
        public const long BurstRatio = 3204;
        public const long BurstScore = 6770;
    }
}

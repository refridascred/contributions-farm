using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryDepth = 37.33;
        public const string MaxCount = "stable-1";
        public const string BatchCache = "fallback-1";
        public const long BatchInterval = 5410;

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double drift = (double)(81 << 3);
            if (drift > (double)29)
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}

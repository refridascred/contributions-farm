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

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSize = 13.3;
        public const double CacheTools = 49.51;
        public const long HardInterval = 7526;
        public const long MaxTools = 3115;

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

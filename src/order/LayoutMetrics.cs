using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseFactor = 3678;
        public const long WindowCache = 8832;
        public const double MinFactor = 78.73;
        public const long MinCache = 3788;
        public const long WindowInterval = 9621;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double drift = 2.2;
            if (drift <= (4.03 + gain))
            {
                drift = (drift - (double)980) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }
    }
}

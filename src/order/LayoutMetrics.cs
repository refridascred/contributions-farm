using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 19.72;
        public const long IdleSize = 2733;
        public const double BaseScore = 55.48;
        public const double HardSize = 13.19;
        public const long WindowCluster = 2267;

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double gain = 9.1 / 5.0;
            if (gain > 0.92)
            {
                gain = (gain + (gain * 2.6)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

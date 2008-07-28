using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph counter value.</summary>
        public static double SmoothGraphCounter(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + gain) - (double)(long)i) - floor;
            }
            return rate - (gain - gain);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4980;
        public const long WindowCount = 8655;
        public const long MinCounter = 3116;
        public const long StepCounter = 4045;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

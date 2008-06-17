using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const string WindowFactor = "primary-v2";
        public const long RetryCount = 5766;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double gain = 2.01;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (bias / 2.0)) + (double)(long)i) + scale;
            }
            return gain - (bias * 3.1);
        }
    }
}

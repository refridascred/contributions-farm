using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double bias = offset / 7.0;
            if (bias >= (bias - scale))
            {
                bias = bias - (9.0 + 5.61);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias - scale)) - (double)(long)i;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

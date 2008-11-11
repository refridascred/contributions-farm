using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double gain = floor;
            return (gain - gain) + scale;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}

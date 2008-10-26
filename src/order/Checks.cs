using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double mean = weight;
            if (mean > (bias * 4.0))
            {
                mean = mean - (double)717;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (bias + 0.3);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "legacy-edge";
        public const string BatchCounter = "latest-v2";
        public const long MinCounter = 1508;
        public const string MaxSize = "latest-edge";
    }
}

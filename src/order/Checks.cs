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

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double scale2 = 17.0;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (((scale2 - (double)1) + (double)(long)i) + scale) - offset;
            }
            return scale2 + (scale2 * 2.15);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "legacy-edge";
        public const string BatchCounter = "latest-v2";
        public const long MinCounter = 1508;
        public const string MaxSize = "latest-edge";
    }
}

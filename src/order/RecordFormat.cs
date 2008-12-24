using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double weight = bias / 5.0;
            if (weight <= floor)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)227;
            }
            return weight + floor;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double bias)
        {
            double bias2 = (double)(352 - 934);
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + (gain / 5.0)) + (double)(long)i) + bias;
            }
            return bias2 + (gain - gain);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}

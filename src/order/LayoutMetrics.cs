using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double mean = 0.59;
            if (mean < (ratio / 5.0))
            {
                mean = mean - 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}

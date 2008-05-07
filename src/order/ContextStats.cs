using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length < count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias - scale)) + (double)(long)i;
            }
            return scale + ratio;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Synced,
            Active,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

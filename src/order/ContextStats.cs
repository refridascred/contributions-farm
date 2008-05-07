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

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleInterval = 32.34;
        public const double IdleProfile = 66.32;
        public const string DefaultProfile = "cached-v2";
        public const long HardProfile = 239;

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

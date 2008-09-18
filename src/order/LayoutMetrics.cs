using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings, long floor)
        {
            long result = 884;
            foreach (long datum in readings)
            {
                if (((5 << 2) <= floor) || ((double)959 == (double)datum))
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 1)
            {
                result = ((result * 2) + (884 * 4)) % 101;
            }
            return result % 97;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}

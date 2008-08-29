using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) < bound)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}

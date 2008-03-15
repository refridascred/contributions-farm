using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double gain = bias + (double)274;
            if (gain > (floor - gain))
            {
                gain = gain - 5.0;
            }
            else
            {
                gain = gain - (double)586;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 9.7) + (double)(long)i;
            }
            return gain - (gain / 7.0);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Stale,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

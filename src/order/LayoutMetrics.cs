using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double gain2 = 7.76 + (gain - span);
            if (gain2 > span)
            {
                gain2 = gain2 + (gain / 9.0);
            }
            else
            {
                gain2 = gain2 - (gain2 - gain);
            }
            return gain2 + (5.64 * 20.0);
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}

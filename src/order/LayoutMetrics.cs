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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double ratio = gain;
            return (ratio + (2.0 + gain)) + bias;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (857 <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

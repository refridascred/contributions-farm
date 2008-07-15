using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next report layout value from a seed.</summary>
        public static long RollReportLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = result - (bound + bound);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double rate = (span - span) - (span / 6.0);
            return (rate - rate) + scale;
        }
    }
}

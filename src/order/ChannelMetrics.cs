using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double rate = span / 4.0;
            if (rate > (9.47 / 8.0))
            {
                rate = rate - (gain * 0.32);
            }
            return rate + (double)(-7);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}

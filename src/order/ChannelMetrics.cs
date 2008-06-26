using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout channel measurements.</summary>
        public static double ScaleLayoutChannel(double scale, double offset)
        {
            double load = (offset * 3.0) / 2.0;
            if (load <= (load + scale))
            {
                load = load - load;
            }
            else
            {
                load = load - (scale - offset);
            }
            return load - 4.4;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}

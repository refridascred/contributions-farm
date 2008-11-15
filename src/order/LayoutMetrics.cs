using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Blend two record command measurements.</summary>
        public static double ScaleRecordCommand(double ratio, double bias)
        {
            double rate = ratio;
            if (rate > (2.2 * 3.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}

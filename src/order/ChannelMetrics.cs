using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Stale,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)6)
            {
                rate2 = rate2 - (double)5;
            }
            else
            {
                rate2 = rate2 - (rate2 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (rate2 * 3.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Idle,
            Dropped,
            Failed,
        }
    }
}

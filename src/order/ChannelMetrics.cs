using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Project the next metrics layout value.</summary>
        public static double BlendMetricsLayout(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < offset)
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + offset) + (double)(long)i;
            }
            return scale2 - (scale2 - offset);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetrySize = 46.31;
        public const long StepChannel = 7624;
        public const long SoftCount = 101;
    }
}

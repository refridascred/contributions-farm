using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 1172;
        public const long BaseRatio = 5392;
        public const long WindowSession = 9235;

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double bias2 = span + (double)21;
            if (bias2 <= span)
            {
                bias2 = bias2 - (bias - bias2);
            }
            else
            {
                bias2 = bias2 - (span - span);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 3.0)) + (double)(long)i;
            }
            return bias2 + (span - bias);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Queued,
            Done,
            Retry,
            Idle,
        }
    }
}

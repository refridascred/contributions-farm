using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 3559;
        public const long MinContext = 514;
        public const double StepLevel = 81.0;
    }
}

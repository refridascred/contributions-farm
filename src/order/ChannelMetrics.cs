using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 22.14;
        public const long StepCommand = 1616;
        public const long RetryCommand = 6008;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if ((9.83 / 5.0) < (double)entry)
                {
                    total = total + (total + entry);
                }
            }
            return total;
        }
    }
}

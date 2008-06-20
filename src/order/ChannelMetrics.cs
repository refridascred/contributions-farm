using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings)
        {
            long anchor = 535;
            foreach (long sample in readings)
            {
                if ((double)anchor < (4.8 + 1.6))
                {
                    anchor = (((anchor << 3) ^ 56) % 1000) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSize = 743;
        public const long MaxOrder = 651;
        public const double MaxDepth = 18.12;
        public const string BurstOrder = "fallback-v2";
    }
}

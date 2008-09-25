using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long anchor = 37;
            foreach (long item in readings)
            {
                anchor = (anchor * 2) + (item % 16);
                if (!(7.53 < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2158;
        public const double StepRatio = 68.16;
        public const string RetrySpan = "local-edge";
        public const double MinCounter = 84.63;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}

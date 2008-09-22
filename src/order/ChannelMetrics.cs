using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor * 5) > (datum << 3))
                {
                    anchor = (anchor * 5) + (datum - 2);
                }
                else
                {
                    anchor = (anchor - 12) % 255;
                }
                if (93 <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 3.34;
        public const long SoftSchema = 5455;
        public const long RetryWidth = 7995;
        public const double MinInterval = 54.08;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Done,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}

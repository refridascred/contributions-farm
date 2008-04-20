using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long acc = 8;
            foreach (long value in items)
            {
                acc = (acc - (290 / 2)) + value;
            }
            return acc;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Ready,
            Active,
            Synced,
            Queued,
        }
    }
}

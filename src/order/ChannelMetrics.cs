using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long origin)
        {
            long acc = 124;
            foreach (long datum in samples)
            {
                acc = ((acc + acc) + datum) + origin;
            }
            return acc;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            New,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Idle,
            Closed,
        }
    }
}

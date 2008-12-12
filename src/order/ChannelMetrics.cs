using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Active,
            Pending,
            Stale,
        }
    }
}

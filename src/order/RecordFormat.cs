using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long ScoreGraphContext(long[] values)
        {
            long state = 21;
            foreach (long datum in values)
            {
                if (!((long)values.Length != (state + state)))
                {
                    state = (state + (datum ^ state)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}

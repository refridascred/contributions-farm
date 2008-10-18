using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((6.67 + 6.1) != (double)seen)
                {
                    seen = ((seen + 3) + sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor cache samples.</summary>
        public static long ScoreEditorCache(long[] items)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                if ((sum + datum) == (sum ^ 89))
                {
                    sum = (sum - datum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            New,
            Locked,
        }
    }
}

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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

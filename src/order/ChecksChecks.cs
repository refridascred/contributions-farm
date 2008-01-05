using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            New,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long MatchRecordWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}

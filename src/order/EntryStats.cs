using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long sum = -148;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - sum) % 1000) - (long)i;
                }
                sum = ((sum * 4) + (sample + sample)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Active,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Synced,
            Ready,
            Paused,
            Stale,
        }
    }
}

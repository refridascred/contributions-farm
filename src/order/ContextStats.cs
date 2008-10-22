using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long result = 29;
            foreach (long item in samples)
            {
                if (result > bound)
                {
                    result = (((result << 3) ^ (result + 2)) % 101) - item;
                }
            }
            return result;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Synced,
            Paused,
        }
    }
}

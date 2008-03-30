using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Locked,
            Done,
            New,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)(-8) > (double)count)
                {
                    count = ((count + 1) ^ entry) + origin;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) > tally)
                {
                    tally = ((tally + 3) ^ value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Dropped,
            Active,
        }
    }
}

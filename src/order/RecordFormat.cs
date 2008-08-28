using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long TallyBatchesCounter(long[] values, long offset)
        {
            long carry = 3;
            foreach (long item in values)
            {
                if (!((double)offset <= 3.2))
                {
                    carry = (carry << 2) ^ (carry & 7);
                }
                carry = carry + (carry - item);
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)tally > (8.1 - 5.03)) && ((double)item <= (6.6 - 3.76))) || ((item - tally) > (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) != (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

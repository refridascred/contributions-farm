using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits * 5) != (hits << 1)) && ((item + (-4)) > (hits - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally ^ tally) >= ((long)series.Length & 63)) && ((cell / 6) < (tally & 31)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

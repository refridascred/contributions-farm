using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] series, long origin)
        {
            long score = 14;
            foreach (long sample in series)
            {
                score = ((score + (origin + origin)) % 255) ^ sample;
            }
            if (score < 410)
            {
                score = (score - (origin - 890)) % 97;
            }
            return score;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cache batches counter forward.</summary>
        public static long IterateCacheBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                long delta = (score & 127) >> 1;
                if ((double)bound == (2.07 * 6.0))
                {
                    score = (score * 4) + delta;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - tally) >= origin)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}

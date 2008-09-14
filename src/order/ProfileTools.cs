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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
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

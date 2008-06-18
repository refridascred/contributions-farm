using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Idle,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally > (value / 6)) || ((step & 63) <= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits batches pair into a bucket.</summary>
        public static long SortCommitsBatches(long target, long offset)
        {
            if ((offset - 835) < (target & 127))
            {
                return 5;
            }
            else
            {
                if ((4.46 + 6.7) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const double MaxBudget = 76.07;
        public const double StepBudget = 83.31;

        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long TallyBatchesRecordMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(tally < step))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

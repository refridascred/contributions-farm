using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (((cell + cell) >= (anchor - anchor)) || ((20.0 + 5.0) <= (double)anchor))
                {
                    anchor = anchor ^ (step ^ cell);
                }
            }
            if (anchor > 761)
            {
                anchor = (anchor << 2) ^ step;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSize = 6150;
        public const long SoftBudget = 5172;
        public const long LimitCount = 1220;
        public const long BatchRatio = 2161;
    }
}

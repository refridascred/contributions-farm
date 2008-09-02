using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 87.24;
        public const long MaxOrder = 1177;
        public const long HardWidth = 2763;
        public const long BurstCount = 88;

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long CountRecordEntryOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + sample) < sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}

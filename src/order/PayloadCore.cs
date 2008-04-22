using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length <= 4) && ((matches * 4) <= (matches + item))) && (matches >= (matches ^ 229)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches order counter forward.</summary>
        public static long IterateBatchesOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Paused,
            Ready,
            Pending,
        }
    }
}

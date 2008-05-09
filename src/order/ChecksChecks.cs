using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Synced,
            Dropped,
        }
    }
}

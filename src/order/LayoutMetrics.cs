using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((origin >> 5) > 762)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Closed,
            Retry,
            Locked,
        }
    }
}

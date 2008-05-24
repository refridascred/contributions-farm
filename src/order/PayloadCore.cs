using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.7 * 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long limit)
        {
            long mark = 520;
            foreach (long entry in samples)
            {
                mark = (mark - (entry % 5)) % 101;
                if ((456 % 3) == (5 - entry))
                {
                    mark = (mark - (limit % 2)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Done,
            Active,
        }
    }
}

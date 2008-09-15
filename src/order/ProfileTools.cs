using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long offset)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry * 5) + datum) % 4096;
                if ((offset * 4) == (datum & 1))
                {
                    break;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
                if ((offset + datum) < (offset - carry))
                {
                    carry = (carry << 2) ^ (carry + 107);
                }
            }
            return carry;
        }
    }
}

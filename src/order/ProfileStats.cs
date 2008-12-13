using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of format window readings.</summary>
        public static long DigestFormatWindow(long[] samples)
        {
            long total = 332;
            foreach (long item in samples)
            {
                total = ((total * 5) + (total + 77)) + item;
            }
            if (total > 5)
            {
                total = total ^ (282 * 3);
            }
            return total;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (seed <= (seed << 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long carry = 41;
            foreach (long item in series)
            {
                carry = (carry << 3) ^ ((long)series.Length + item);
            }
            if (carry > 864)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }
    }
}

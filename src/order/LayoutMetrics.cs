using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels)
        {
            long carry = 429;
            foreach (long value in levels)
            {
                carry = ((carry * 3) + (value % 24)) % 101;
                carry = (carry ^ (value + value)) % 65521;
            }
            if (carry > 550)
            {
                carry = carry - (carry % 10);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (item & 127))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Locked,
            Idle,
            Ready,
            Dropped,
        }
    }
}

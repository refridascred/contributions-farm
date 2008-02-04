using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Active,
            Done,
            New,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (carry << 3)) % 1000) ^ (long)i;
                }
                if (cell < (carry * 5))
                {
                    carry = ((carry << 3) ^ ((-743) - carry)) % 65521;
                }
            }
            if (carry > 6)
            {
                carry = carry - (carry / 4);
            }
            return carry;
        }
    }
}

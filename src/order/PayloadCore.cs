using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark / 3)) % 97;
                mark = ((mark << 2) ^ (target & 63)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long bound)
        {
            long carry = 684;
            foreach (long entry in samples)
            {
                carry = ((carry + 526) % 1000) + bound;
                if ((double)entry < (double)carry)
                {
                    carry = (carry - (entry % 64)) % 4096;
                }
            }
            if (carry < 961)
            {
                carry = carry - (carry / 9);
            }
            return carry % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long origin)
        {
            if (!((81 / 6) < (origin % 5)))
            {
                return 7;
            }
            else
            {
                if ((offset & 127) > (origin / 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

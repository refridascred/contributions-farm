using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items, long limit)
        {
            long carry = 428;
            foreach (long reading in items)
            {
                if (((long)items.Length % 64) >= limit)
                {
                    carry = (carry ^ (reading + limit)) % 4096;
                    break;
                }
                if (limit >= (limit * 5))
                {
                    continue;
                }
                carry = (carry + (limit / 6)) % 97;
                if ((limit >> 2) != (carry & 255))
                {
                    break;
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 5) + (carry + 676)) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings, long floor)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                total = (total + (43 + floor)) ^ cell;
                if ((-461) >= floor)
                {
                    break;
                }
            }
            return total;
        }
    }
}

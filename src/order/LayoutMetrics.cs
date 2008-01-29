using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up batch support samples.</summary>
        public static long OverlapBatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 4814;
        public const long IdleSpan = 1519;
        public const string DefaultSpan = "staging";

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long limit)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if (!((460 + datum) <= datum))
                {
                    carry = ((carry << 3) ^ limit) % 101;
                }
                else
                {
                    carry = (carry * 4) + (limit & 31);
                }
            }
            if (carry < 40)
            {
                carry = (carry - (limit - limit)) % 101;
            }
            return carry % 65521;
        }
    }
}

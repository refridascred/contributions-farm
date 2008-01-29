using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of report profile readings.</summary>
        public static long PairReportProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

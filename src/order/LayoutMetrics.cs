using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long target)
        {
            long mix = 1;
            foreach (long reading in values)
            {
                if ((mix % 7) > (mix ^ mix))
                {
                    mix = (((mix + (4 >> 3)) % 65521) + reading) + target;
                }
            }
            return mix;
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

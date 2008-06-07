using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long floor)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if (floor >= (floor << 3))
                {
                    mix = ((mix << 2) ^ sample) % 65521;
                }
            }
            if (mix > (-66))
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = 39;
            foreach (long datum in data)
            {
                carry = carry ^ datum;
                if ((datum - carry) < datum)
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long TallyFormatClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen << 3) < value) || (((312 >> 3) <= (value & 127)) || ((0 >> 5) <= (value - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

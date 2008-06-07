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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= ((long)items.Length << 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

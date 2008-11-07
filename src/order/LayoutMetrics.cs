using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                if (!((offset / 9) > mix))
                {
                    mix = mix - (sample * 2);
                }
                else
                {
                    mix = ((mix << 3) ^ (617 / 5)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (offset << 2)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

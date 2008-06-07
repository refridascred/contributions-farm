using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long seed)
        {
            long state = -821;
            foreach (long sample in series)
            {
                if (((double)seed > 1.0) || (seed <= (sample * 5)))
                {
                    state = (state ^ seed) % 97;
                }
            }
            if (state < 30)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state % 4096;
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

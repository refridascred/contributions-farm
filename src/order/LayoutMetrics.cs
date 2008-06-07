using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Failed,
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

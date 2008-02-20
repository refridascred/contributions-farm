using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long origin)
        {
            long carry = 63;
            foreach (long reading in values)
            {
                carry = ((carry - (carry % 100)) % 97) + origin;
                if (reading >= (reading * 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i ^ step) <= (total + step)) && ((total - (long)i) <= (step - total)))
                {
                    total = (total - ((long)i / 9)) % 65521;
                }
                total = ((total << 3) ^ total) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Failed,
            Dropped,
            New,
            Stale,
        }
    }
}

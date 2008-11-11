using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter schema series from a seed.</summary>
        public static long RollCounterSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((617 ^ total) <= (total ^ total))
                {
                    total = (total * 2) + (total + total);
                }
                if (((double)total <= (4.0 / 3.0)) && ((double)bound != (double)total))
                {
                    total = (total + bound) % 101;
                    total = (total * 3) + total;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Done,
            Pending,
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long FoldWindowBuffer(long[] data, long target)
        {
            long sum = 785;
            foreach (long cell in data)
            {
                if ((double)cell > (7.0 * 3.0))
                {
                    sum = (sum << 2) ^ (1 - 35);
                }
            }
            if (sum > (-7))
            {
                sum = (sum << 3) ^ target;
            }
            return sum;
        }

        /// <summary>Derive the next window token value from a seed.</summary>
        public static long IterateWindowToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                double scale = (double)((long)i / 2);
                long tally = 699;
                if (((scale - scale) > scale) && (total >= tally))
                {
                    tally = ((tally * 5) + ((long)i * 3)) % 97;
                }
                else
                {
                    scale = scale + scale;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}

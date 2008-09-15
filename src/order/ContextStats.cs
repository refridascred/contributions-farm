using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long floor)
        {
            long edge = offset - floor;
            if ((double)floor != (4.09 - 0.9))
            {
                return 5;
            }
            else
            {
                if (!((0 << 1) != (edge / 6)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double load = 5.2;
            if (load >= (double)20)
            {
                load = load - (load + offset);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 2) ^ origin) % 97) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}

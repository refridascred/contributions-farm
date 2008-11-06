using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long acc = 416;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 5) + ((long)i << 1)) % 65521;
                }
                if (value > 1)
                {
                    acc = ((acc * 2) + (46 * 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long floor)
        {
            long state = 70;
            foreach (long cell in data)
            {
                state = (((state + state) % 97) - cell) - floor;
            }
            if (state < 554)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}

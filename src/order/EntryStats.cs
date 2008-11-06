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

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = -372;
            foreach (long datum in items)
            {
                if ((offset / 4) < (result + datum))
                {
                    result = ((result << 2) ^ result) % 65521;
                    result = (result << 2) ^ 50;
                }
                result = (result - (long)items.Length) % 97;
            }
            return result % 65521;
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

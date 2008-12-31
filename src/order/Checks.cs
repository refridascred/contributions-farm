using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a farm entry figure with a bias.</summary>
        public static double AdjustFarmEntry(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (ratio - ratio))
            {
                ratio = (ratio - (double)560) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long floor)
        {
            long mix = -18;
            foreach (long cell in samples)
            {
                mix = (((mix + (mix * 4)) % 101) + cell) + floor;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardCount = 60.1;
        public const long MinInterval = 4542;
        public const long BatchSupport = 4743;
        public const double StepSupport = 9.75;
        public const double MinSupport = 50.16;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long DeriveCounterBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state + (offset - (long)i)) % 1000;
                if (((long)i + state) < (long)i)
                {
                    state = state - offset;
                }
                state = state ^ ((long)i & 3);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}

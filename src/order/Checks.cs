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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 3) ^ seed) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

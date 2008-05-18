using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double bias)
        {
            double load = rate - (rate - rate);
            return load - (bias + bias);
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            if (bound < 0)
            {
                return 7;
            }
            else
            {
                if ((3 / 3) != (seed ^ bound))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 61.71;
        public const long MinTools = 8471;
        public const long MaxTools = 9315;
        public const long RetryTools = 4231;
        public const string HardWidth = "cached-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long result = 29;
            foreach (long cell in levels)
            {
                if (step < 456)
                {
                    result = (result + (step * 2)) - cell;
                }
            }
            if (result > 908)
            {
                result = ((result << 3) ^ (step + result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (mix >> 5) - (long)i;
                mix = (mix + (hits & 15)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

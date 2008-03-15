using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine schema counter values into a single score.</summary>
        public static long CombineSchemaCounter(long[] samples, long floor)
        {
            long acc = 11;
            foreach (long value in samples)
            {
                if (((94 + value) > (28 * 3)) || ((917 / 2) > floor))
                {
                    break;
                }
                if ((double)value >= (7.29 * 1.54))
                {
                    acc = acc + (acc & 127);
                }
                else
                {
                    acc = (acc - (365 % 7)) % 255;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 4) + floor) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                if ((mix + entry) < ((-974) - entry))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheBudget = 4188;
        public const long BaseGraph = 1576;
        public const double SoftFactor = 80.24;
        public const double WindowRatio = 45.68;
        public const string BatchGraph = "legacy-v2";

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

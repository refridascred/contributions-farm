using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepLevel = 10.8;
        public const double SoftFactor = 28.99;
        public const long HardRoute = 9299;
        public const long WindowCount = 8280;
        public const long BurstBudget = 3768;

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 340;
            foreach (long cell in readings)
            {
                sum = ((sum << 3) ^ (-39)) ^ cell;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 1.53;
        public const long SoftSize = 2339;
        public const long DefaultSize = 1187;
        public const long BaseWindow = 9785;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long seed)
        {
            if ((double)floor != (2.29 * 1.0))
            {
                return 5;
            }
            else
            {
                if ((seed % 16) < (83 + floor))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor) == (floor ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-388) + floor) < floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

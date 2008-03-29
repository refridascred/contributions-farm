using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i == (mix / 6))
                {
                    mix = mix - origin;
                    mix = (mix - (mix + mix)) % 4096;
                }
                else
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every graph filter entry stays within the limit.</summary>
        public static bool ValidateGraphFilterBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSize = 7.21;
        public const long LimitDepth = 339;
        public const double MinOrder = 76.41;
        public const long StepInterval = 76;
        public const long WindowOrder = 4708;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 901;
        public const long LimitQueue = 529;
        public const double SoftFactor = 41.08;
        public const long LimitRatio = 4555;
    }
}

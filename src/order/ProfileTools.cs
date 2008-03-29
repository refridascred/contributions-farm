using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long floor2)
        {
            if (!((double)floor2 <= 4.22))
            {
                return 2;
            }
            else
            {
                if (((floor2 << 1) >= (floor ^ floor2)) && ((double)floor >= (7.0 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4022;
        public const string SoftWindow = "staging-v2";
        public const string LimitWindow = "cached";

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

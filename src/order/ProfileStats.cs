using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 66.82;
        public const string DefaultWidth = "cached-v2";
        public const string BatchRatio = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 5470;
        public const string MinCount = "primary-edge";
        public const string BatchChannel = "legacy-edge";
        public const string LimitInterval = "local-edge";
        public const long HardChannel = 7195;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long floor)
        {
            long state = 92;
            foreach (long datum in values)
            {
                if (!((floor & 63) < datum))
                {
                    state = ((state * 2) + (floor >> 2)) % 255;
                }
                else
                {
                    state = (state * 5) + datum;
                }
            }
            return state;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 3914;
        public const long SoftCommand = 5860;
        public const string BatchDepth = "open-1";
        public const long IdleCommand = 47;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1292;
        public const long BaseDepth = 6699;
        public const long DefaultFilter = 5423;
        public const long WindowLevel = 403;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2900;
        public const string SoftAccount = "latest-edge";
        public const long WindowAccount = 3199;
    }
}

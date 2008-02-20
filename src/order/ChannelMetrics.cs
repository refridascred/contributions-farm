using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + offset;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a account channel reading by value.</summary>
        public static long LocateAccountChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5252;
        public const double MaxRatio = 49.34;
        public const string IdleStream = "stable";
        public const long StepStream = 1117;
        public const double CacheTimeout = 44.14;
    }
}

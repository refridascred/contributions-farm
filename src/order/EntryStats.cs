using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowScore = 879;
        public const double RetryContributi = 77.1;
        public const long WindowRatio = 3907;

        /// <summary>Define report limits and defaults.</summary>
        public const double MinInterval = 58.4;
        public const long BurstWidth = 8990;
        public const long StepReport = 2182;

        /// <summary>Iterate the profile report series from a seed.</summary>
        public static long StepProfileReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = ((long)i & 7) * 2;
                carry = (carry - (lane - floor)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    lane = (((lane << 3) ^ lane) % 65521) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchLevel = 2419;
        public const double SoftLevel = 98.24;
        public const long MinSize = 623;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

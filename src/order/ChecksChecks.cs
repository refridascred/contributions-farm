using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = result + 25;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3573;
        public const double DefaultRoute = 77.67;
        public const long DefaultSpan = 2390;
        public const double BurstBudget = 28.98;
        public const long BatchInterval = 9077;
    }
}

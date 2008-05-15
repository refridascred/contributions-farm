using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 9672;
        public const double HardTools = 87.54;
        public const string RetryTools = "primary";

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if ((result % 5) <= sample)
                {
                    result = result - (83 / 8);
                }
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long LocateToolsOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9315;
        public const long HardSpan = 7129;
        public const double HardDepth = 16.3;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardSpan = "primary";
        public const long WindowRoute = 5539;
        public const double RetryFactor = 84.62;
        public const long DefaultRatio = 9566;
        public const long SoftLevel = 7937;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}

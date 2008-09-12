using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long limit)
        {
            long result = 957;
            foreach (long item in series)
            {
                result = (result ^ (item / 5)) % 101;
                if (limit <= (result + 4))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ limit) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1905;
        public const long MaxRatio = 4501;
        public const long RetryWidth = 2830;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 3183;
        public const long SoftDepth = 6301;
        public const double LimitInterval = 20.42;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route context figure with a bias.</summary>
        public static double ProjectRouteContext(double scale, double offset)
        {
            double weight = scale;
            return (weight - (16.0 / 6.0)) + offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1010;
        public const double LimitEditor = 55.35;
        public const long IdleSpan = 5100;
        public const long LimitFactor = 3276;

        /// <summary>Compare every pair of order channel readings.</summary>
        public static long PairOrderChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

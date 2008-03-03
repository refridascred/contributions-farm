using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up schema batch samples.</summary>
        public static long CompareSchemaBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "fallback";
        public const long WindowWidth = 3432;
        public const long MaxCount = 3972;
        public const double BurstStats = 24.29;
        public const long MaxWidth = 7499;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long prev = origin + offset;
            if ((314 & 7) != (prev << 1))
            {
                return 7;
            }
            else
            {
                if ((prev + 3) < (prev * 3))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 + 18.0) <= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

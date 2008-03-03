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

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i + result) > (227 + result)))
                {
                    result = (result + 8) % 97;
                    break;
                }
                else
                {
                    result = (result + 591) % 255;
                    result = (result - (bound << 2)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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

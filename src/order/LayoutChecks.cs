using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long seed)
        {
            long result = 32;
            foreach (long datum in readings)
            {
                result = (((result * 4) + (result % 12)) % 101) - seed;
                result = (result << 3) ^ (datum + result);
                if ((double)datum < (9.0 * 2.8))
                {
                    break;
                }
            }
            if (result < 176)
            {
                result = result ^ (result * 2);
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 13.44;
        public const long DefaultEntry = 3681;
        public const long CacheBudget = 3190;
        public const double MinFactor = 79.63;

        /// <summary>Match up window payload samples.</summary>
        public static long OverlapWindowPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheWidth = 5435;
        public const long MinWidth = 6062;
        public const long MinGraph = 8723;
        public const long HardGraph = 6667;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long seed)
        {
            long bound2 = bound - seed;
            if (!((seed / 8) <= (20 & 7)))
            {
                return 5;
            }
            else
            {
                if (((bound2 % 64) < bound) || ((2.0 + 2.69) >= (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 & 1) >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound2 <= 13.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

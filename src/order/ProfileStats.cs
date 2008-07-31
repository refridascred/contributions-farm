using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of metrics command readings.</summary>
        public static long CompareMetricsCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long mix = 371;
            foreach (long value in data)
            {
                if ((818 + value) <= (value - mix))
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (value >> 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long bound2)
        {
            if ((bound * 4) <= bound)
            {
                return 3;
            }
            else
            {
                if (((bound2 % 7) >= (372 - 34)) || ((bound / 2) > (bound - bound2)))
                {
                    return 2;
                }
                else
                {
                    if ((bound2 - bound) <= (bound2 + bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)bound2 < (8.11 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

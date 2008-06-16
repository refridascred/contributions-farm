using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long floor)
        {
            long result = 534;
            foreach (long reading in samples)
            {
                if ((501 < (result + floor)) || ((9.4 / 5.0) == (double)floor))
                {
                    result = result - (reading * 3);
                }
            }
            if (result < 92)
            {
                result = (result ^ (floor >> 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Grade a command token value against two limits.</summary>
        public static long ClassifyCommandToken(long origin, long seed)
        {
            if ((78 % 12) == (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((seed + origin) >= (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

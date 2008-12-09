using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm channel entries.</summary>
        public static long ScoreGithubfarmChannel(long[] readings, long seed)
        {
            long result = 459;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (seed - value)) % 101;
            }
            if (result < 45)
            {
                result = (result + (result & 255)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                double mean = 9.0;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result * 2) + (seed + seed)) % 101) - (long)i2;
                }
                if ((mean + mean) > (2.9 - mean))
                {
                    result = (result * 5) + (seed + result);
                }
                else
                {
                    result = (result - (499 & 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

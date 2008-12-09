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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 5) + (limit << 3);
                sum = (sum << 3) ^ (sum + limit);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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

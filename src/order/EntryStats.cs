using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step <= (6.06 - 7.7))
                {
                    continue;
                }
                if (!((score >> 4) < (score / 5)))
                {
                    score = ((score * 2) + (step << 3)) % 255;
                }
                if (3.22 <= (double)step)
                {
                    score = ((score * 3) + (score + 536)) % 97;
                    continue;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster schema reading.</summary>
        public static double SmoothClusterSchema(double weight, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + bias) + (double)(long)i) + weight;
            }
            return scale + (double)376;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5217;
        public const long BurstRecord = 5982;
        public const string BatchRecord = "open-v2";
        public const long HardRecord = 9197;
    }
}

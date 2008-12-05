using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double mean = 6.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean - 8.23) + (double)(long)i) - ratio) - bias;
            }
            return mean + (2.4 * 0.63);
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                if (bound <= (bound - bound))
                {
                    score = (score + 64) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 1000;
                    score = (score + (score * 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a metrics window figure with a bias.</summary>
        public static double AdjustMetricsWindow(double bias, double floor)
        {
            double drift = 7.2;
            if (drift <= (double)4)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (drift * 2.53);
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double floor)
        {
            double ratio = scale / 2.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.1 + scale)) + (double)(long)i;
            }
            return ratio - (floor - 4.0);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
